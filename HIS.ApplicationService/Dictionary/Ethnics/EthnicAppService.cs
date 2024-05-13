using Microsoft.EntityFrameworkCore;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities;
using HIS.Core.Domain.Repositories;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using System.Transactions;
using HIS.ApplicationService.Dictionary.Ethnics.Dto;

namespace HIS.ApplicationService.Dictionary.Ethnics
{
    public class EthnicAppService : BaseAppService, IEthnicAppService
    {
        private readonly IRepository<Ethnicity, Guid> _ethnicRepository;

        public EthnicAppService(IRepository<Ethnicity, Guid> ethnicRepository) 
        {
            _ethnicRepository = ethnicRepository;
        }

        public virtual async Task<PagedResultDto<EthnicDto>> GetAllAsync(GetAllEthnicInputDto input)
        {
            var result = new PagedResultDto<EthnicDto>();
            try
            {
                var filter = _ethnicRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<EthnicDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<EthnicDto>> GetAsync(Guid id)
        {
            var result = new ResultDto<EthnicDto>();
            try
            {
                var entity = await _ethnicRepository.GetAsync(id);
                result.Result = ObjectMapper.Map<EthnicDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<EthnicDto>> CreateOrUpdateAsync(EthnicDto input)
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

        public virtual async Task<ResultDto<EthnicDto>> CreateAsync(EthnicDto input)
        {
            var result = new ResultDto<EthnicDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<Ethnicity>(input);

                    await _ethnicRepository.InsertAsync(entity);

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

        public virtual async Task<ResultDto<EthnicDto>> UpdateAsync(EthnicDto input)
        {
            var result = new ResultDto<EthnicDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _ethnicRepository.GetAsync(input.Id.Value);

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

        public virtual async Task<ResultDto<EthnicDto>> DeleteAsync(Guid id)
        {
            var result = new ResultDto<EthnicDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _ethnicRepository.Get(id);

                    await _ethnicRepository.DeleteAsync(entity);

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
