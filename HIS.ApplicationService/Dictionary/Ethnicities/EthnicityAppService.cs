using Microsoft.EntityFrameworkCore;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using HIS.ApplicationService.Dictionary.Ethnicities.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Dictionary.DepartmentTypes.Dto;
using System.Transactions;

namespace HIS.ApplicationService.Dictionary.Ethnicities
{
    public class EthnicityAppService : BaseAppService, IEthnicityAppService
    {
        private readonly IRepository<Ethnicity, Guid> _ethnicityRepository;

        public EthnicityAppService(IRepository<Ethnicity, Guid> ethnicityRepository) 
        {
            _ethnicityRepository = ethnicityRepository;
        }

        public virtual async Task<PagedResultDto<EthnicityDto>> GetAllAsync(GetAllEthnicityInputDto input)
        {
            var result = new PagedResultDto<EthnicityDto>();
            try
            {
                var filter = _ethnicityRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(s => s.SortOrder).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<EthnicityDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<EthnicityDto>> GetAsync(Guid id)
        {
            var result = new ResultDto<EthnicityDto>();
            try
            {
                var ethnicity = await _ethnicityRepository.GetAsync(id);
                result.Result = ObjectMapper.Map<EthnicityDto>(ethnicity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<EthnicityDto>> CreateOrUpdateAsync(EthnicityDto input)
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

        public virtual async Task<ResultDto<EthnicityDto>> CreateAsync(EthnicityDto input)
        {
            var result = new ResultDto<EthnicityDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<Ethnicity>(input);

                    await _ethnicityRepository.InsertAsync(entity);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<EthnicityDto>> UpdateAsync(EthnicityDto input)
        {
            var result = new ResultDto<EthnicityDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _ethnicityRepository.GetAsync(input.Id.Value);

                    ObjectMapper.Map(input, entity);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<EthnicityDto>> DeleteAsync(Guid id)
        {
            var result = new ResultDto<EthnicityDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _ethnicityRepository.Get(id);

                    await _ethnicityRepository.DeleteAsync(entity);

                    unitOfWork.Complete();
                    result.Success(null);
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
