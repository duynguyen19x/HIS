using HIS.ApplicationService.System.LayoutTemplates;
using HIS.ApplicationService.Systems.LayoutTemplates.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.Dtos.Dictionaries.Branchs;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.System;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HIS.ApplicationService.Systems.LayoutTemplate
{
    public class ListLayoutTemplateAppService : BaseAppService, IListLayoutTemplateAppService
    {
        private readonly IRepository<EntityFrameworkCore.Entities.System.ListLayoutTemplate, Guid> _sysLayoutTemplateRepository;

        public ListLayoutTemplateAppService(IRepository<EntityFrameworkCore.Entities.System.ListLayoutTemplate, Guid> sysLayoutTemplateRepository) 
        {
            _sysLayoutTemplateRepository = sysLayoutTemplateRepository;
        }

        public async Task<ResultDto<ListLayoutTemplateDto>> CreateOrUpdateAsync(ListLayoutTemplateDto input)
        {
            if (Check.IsNullOrDefault(input.Id))
            {
                return await CreateAsync(input);
            }    
            else
            {
                return await UpdateAsync(input);
            }    
        }

        public async Task<ResultDto<ListLayoutTemplateDto>> CreateAsync(ListLayoutTemplateDto input)
        {
            var result = new ResultDto<ListLayoutTemplateDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<EntityFrameworkCore.Entities.System.ListLayoutTemplate>(input);

                    await _sysLayoutTemplateRepository.InsertAsync(entity);
                    unitOfWork.Complete();

                    result.Result = input;
                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async Task<ResultDto<ListLayoutTemplateDto>> UpdateAsync(ListLayoutTemplateDto input)
        {
            var result = new ResultDto<ListLayoutTemplateDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _sysLayoutTemplateRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);
                    unitOfWork.Complete();

                    result.Result = input;
                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async Task<ResultDto<ListLayoutTemplateDto>> DeleteAsync(Guid id)
        {
            var result = new ResultDto<ListLayoutTemplateDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _sysLayoutTemplateRepository.Get(id);

                    // kiểm tra dữ liệu
                    // không được phép xóa mẫu thuộc hệ thống.
                    if (Check.IsNullOrDefault(entity.UserId))
                    {
                        throw new Exception($"<{entity.Name}> là mẫu thuộc hệ thống. Bạn không được phép xóa!");
                    }

                    // người dùng chỉ được phép xóa mẫu tùy chỉnh của người dùng.
                    if (Check.IsNotEquals(entity.UserId, AppSession.UserId))
                    {
                        throw new Exception($"<{entity.Name}> là mẫu thuộc người dùng khác. Bạn không được phép xóa!");
                    }

                    // xử lý xóa
                    await _sysLayoutTemplateRepository.DeleteAsync(entity);
                    await unitOfWork.CompleteAsync();

                    result.Result = ObjectMapper.Map<ListLayoutTemplateDto>(entity);
                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async Task<PagedResultDto<ListLayoutTemplateDto>> GetAllAsync(GetAllSYSLayoutTemplateInputDto input)
        {
            var result = new PagedResultDto<ListLayoutTemplateDto>();
            try
            {
                var query = _sysLayoutTemplateRepository.GetAll()
                    //.WhereIf(!string.IsNullOrEmpty(input.LayoutTemplateCodeFilter), x => x.Code == input.LayoutTemplateCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.LayoutTemplateNameFilter), x => x.Name == input.LayoutTemplateNameFilter)
                    .WhereIf(input.IsPublicFilter != null, x => x.IsPublic == input.IsPublicFilter)
                    .WhereIf(input.UserFilter != null, x => x.UserId == input.UserFilter);
                var paged = query.ApplySortingAndPaging(input);

                result.TotalCount = await query.CountAsync();
                result.Result = ObjectMapper.Map<IList<ListLayoutTemplateDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async Task<ResultDto<ListLayoutTemplateDto>> GetAsync(Guid id)
        {
            var result = new ResultDto<ListLayoutTemplateDto>();
            try
            {
                var entity = await _sysLayoutTemplateRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<ListLayoutTemplateDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }
    }
}
