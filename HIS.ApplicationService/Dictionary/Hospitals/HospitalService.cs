using HIS.ApplicationService.Dictionary.Hospitals.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace HIS.ApplicationService.Dictionary.Hospitals
{
    public class HospitalService : BaseAppService, IHospitalService
    {
        private readonly IRepository<Hospital, Guid> _hospitalRepository;

        public HospitalService(IRepository<Hospital, Guid> hospitalRepository)
        {
            _hospitalRepository = hospitalRepository;
        }

        public virtual async Task<PagedResultDto<HospitalDto>> GetAll(GetAllHospitalInputDto input)
        {
            var result = new PagedResultDto<HospitalDto>();
            try
            {
                var filter = _hospitalRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<HospitalDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<HospitalDto>> GetById(Guid id)
        {
            var result = new ResultDto<HospitalDto>();
            try
            {
                var entity = await _hospitalRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<HospitalDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<HospitalDto>> CreateOrEdit(HospitalDto input)
        {
            if (Check.IsNullOrDefault(input.Id))
            {
                return await Create(input);
            }
            else
            {
                return await Update(input);
            }
        }

        public virtual async Task<ResultDto<HospitalDto>> Create(HospitalDto input)
        {
            var result = new ResultDto<HospitalDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<Hospital>(input);

                    await _hospitalRepository.InsertAsync(entity);

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

        public virtual async Task<ResultDto<HospitalDto>> Update(HospitalDto input)
        {
            var result = new ResultDto<HospitalDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _hospitalRepository.GetAsync(input.Id.GetValueOrDefault());

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

        public virtual async Task<ResultDto<HospitalDto>> Delete(Guid id)
        {
            var result = new ResultDto<HospitalDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _hospitalRepository.Get(id);

                    await _hospitalRepository.DeleteAsync(entity);

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
