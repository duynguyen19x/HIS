using HIS.Dtos.Systems.RefType;
using HIS.Dtos.Systems;
using Microsoft.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Systems;
using HIS.Core.Domain.Repositories;
using HIS.Core.Services.Dto;
using HIS.Core.Linq.Extensions;
using HIS.Core.Services;
using HIS.Core.Extensions;
using System.Transactions;
using HIS.Core.Runtime.Session;

namespace HIS.ApplicationService.Systems.RefType
{
    public class SYSRefTypeAppService : BaseAppService, ISYSRefTypeAppService
    {
        private readonly IRepository<SYSRefType, int> _sysRefTypeRepository;

        public SYSRefTypeAppService(IRepository<SYSRefType, int> sysRefTypeRepository) 
        {
            _sysRefTypeRepository = sysRefTypeRepository;
        }

        public virtual async Task<PagedResultDto<SYSRefTypeDto>> GetAllAsync(GetAllSYSRefTypeInputDto input)
        {
            var result = new PagedResultDto<SYSRefTypeDto>();
            try
            {
                var query = _sysRefTypeRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.RefTypeNameFilter), x => x.RefTypeName == input.RefTypeNameFilter)
                    .WhereIf(input.RefTypeCategoryFilter != null, x => x.RefTypeCategoryId == input.RefTypeCategoryFilter);
                var paged = query.ApplySortingAndPaging(input);

                result.TotalCount = await query.CountAsync();
                result.Result = ObjectMapper.Map<IList<SYSRefTypeDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<SYSRefTypeDto>> GetAsync(int id)
        {
            var result = new ResultDto<SYSRefTypeDto>();
            try
            {
                var entity = await _sysRefTypeRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<SYSRefTypeDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<SYSRefTypeDto>> CreateOrUpdateAsync(SYSRefTypeDto input)
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

        public virtual async Task<ResultDto<SYSRefTypeDto>> CreateAsync(SYSRefTypeDto input)
        {
            var result = new ResultDto<SYSRefTypeDto>();
            try
            {
                using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
                {
                    var entity = ObjectMapper.Map<SYSRefType>(input);

                    await _sysRefTypeRepository.InsertAsync(entity);
                    unitOfWork.Complete();

                    result.Result = ObjectMapper.Map<SYSRefTypeDto>(entity);
                    result.IsSucceeded = true;
                }
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<SYSRefTypeDto>> UpdateAsync(SYSRefTypeDto input)
        {
            var result = new ResultDto<SYSRefTypeDto>();
            try
            {
                using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
                {
                    var entity = await _sysRefTypeRepository.GetAsync(input.Id);

                    ObjectMapper.Map(input, entity);
                    unitOfWork.Complete();

                    result.Result = ObjectMapper.Map<SYSRefTypeDto>(entity);
                    result.IsSucceeded = true;
                }
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<SYSRefTypeDto>> DeleteAsync(int id)
        {
            var result = new ResultDto<SYSRefTypeDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                try
                {
                    var entity = _sysRefTypeRepository.Get(id);
                    await _sysRefTypeRepository.DeleteAsync(entity);

                    result.Result = ObjectMapper.Map<SYSRefTypeDto>(entity);
                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }
    }
}
