using HIS.ApplicationService.Systems.LayoutTemplate.Dtos;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.Core.Linq.Extensions;
using HIS.Dtos.Dictionaries.Branchs;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HIS.ApplicationService.Systems.LayoutTemplate
{
    public class SYSLayoutTemplateAppService : BaseAppService, ISYSLayoutTemplateAppService
    {
        private readonly IRepository<SYSLayoutTemplate, Guid> _sysLayoutTemplateRepository;

        public SYSLayoutTemplateAppService(IRepository<SYSLayoutTemplate, Guid> sysLayoutTemplateRepository) 
        {
            _sysLayoutTemplateRepository = sysLayoutTemplateRepository;
        }

        public async Task<ResultDto<SYSLayoutTemplateDto>> CreateOrUpdateAsync(SYSLayoutTemplateDto input)
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

        public async Task<ResultDto<SYSLayoutTemplateDto>> CreateAsync(SYSLayoutTemplateDto input)
        {
            var result = new ResultDto<SYSLayoutTemplateDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<SYSLayoutTemplate>(input);

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

        public async Task<ResultDto<SYSLayoutTemplateDto>> UpdateAsync(SYSLayoutTemplateDto input)
        {
            var result = new ResultDto<SYSLayoutTemplateDto>();
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

        public async Task<ResultDto<SYSLayoutTemplateDto>> DeleteAsync(Guid id)
        {
            var result = new ResultDto<SYSLayoutTemplateDto>();
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
                    if (Check.IsNotEquals(entity.UserId, AppSession.UserID))
                    {
                        throw new Exception($"<{entity.Name}> là mẫu thuộc người dùng khác. Bạn không được phép xóa!");
                    }

                    // xử lý xóa
                    await _sysLayoutTemplateRepository.DeleteAsync(entity);
                    await unitOfWork.CompleteAsync();

                    result.Result = ObjectMapper.Map<SYSLayoutTemplateDto>(entity);
                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async Task<PagedResultDto<SYSLayoutTemplateDto>> GetAllAsync(GetAllSYSLayoutTemplateInputDto input)
        {
            var result = new PagedResultDto<SYSLayoutTemplateDto>();
            try
            {
                var query = _sysLayoutTemplateRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.LayoutTemplateCodeFilter), x => x.Code == input.LayoutTemplateCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.LayoutTemplateNameFilter), x => x.Name == input.LayoutTemplateNameFilter)
                    .WhereIf(input.IsPublicFilter != null, x => x.IsPublic == input.IsPublicFilter)
                    .WhereIf(input.UserFilter != null, x => x.UserId == input.UserFilter);
                var paged = query.ApplySortingAndPaging(input);

                result.TotalCount = await query.CountAsync();
                result.Result = ObjectMapper.Map<IList<SYSLayoutTemplateDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async Task<ResultDto<SYSLayoutTemplateDto>> GetAsync(Guid id)
        {
            var result = new ResultDto<SYSLayoutTemplateDto>();
            try
            {
                var entity = await _sysLayoutTemplateRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<SYSLayoutTemplateDto>(entity);
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
