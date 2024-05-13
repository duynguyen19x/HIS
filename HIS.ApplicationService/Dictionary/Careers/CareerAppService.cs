using HIS.ApplicationService.Dictionary.Careers.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace HIS.ApplicationService.Dictionary.Careers
{
    public class CareerAppService : BaseAppService, ICareerAppService
    {
        private readonly IRepository<Career, Guid> _careerRepository;

        public CareerAppService(
            IRepository<Career, Guid> careerRepository)
        {
            _careerRepository = careerRepository;
        }

        public virtual async Task<PagedResultDto<CareerDto>> GetAllAsync(GetAllCareerInput input)
        {
            var result = new PagedResultDto<CareerDto>();
            try
            {
                var query = _careerRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);
                var paged = query.ApplySortingAndPaging(input);

                result.TotalCount = await query.CountAsync();
                result.Result = ObjectMapper.Map<IList<CareerDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<CareerDto>> GetAsync(Guid id)
        {
            var result = new ResultDto<CareerDto>();
            try
            {
                var entity = await _careerRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<CareerDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<CareerDto>> CreateOrUpdateAsync(CareerDto input)
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

        public virtual async Task<ResultDto<CareerDto>> CreateAsync(CareerDto input)
        {
            var result = new ResultDto<CareerDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var career = ObjectMapper.Map<Career>(input);

                    await _careerRepository.InsertAsync(career);

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

        public virtual async Task<ResultDto<CareerDto>> UpdateAsync(CareerDto input)
        {
            var result = new ResultDto<CareerDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var career = await _careerRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, career);

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

        public virtual async Task<ResultDto<CareerDto>> DeleteAsync(Guid id)
        {
            var result = new ResultDto<CareerDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var branch = _careerRepository.Get(id);

                    await _careerRepository.DeleteAsync(branch);

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
