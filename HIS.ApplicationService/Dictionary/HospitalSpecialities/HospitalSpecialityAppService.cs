using HIS.ApplicationService.Dictionary.HospitalSpecialities.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace HIS.ApplicationService.Dictionary.HospitalSpecialities
{
    public class HospitalSpecialityAppService : BaseAppService, IHospitalSpecialityAppService
    {
        private readonly IRepository<HospitalSpeciality, Guid> _hospitalSpecialityRepository;

        public HospitalSpecialityAppService(IRepository<HospitalSpeciality, Guid> hospitalSpecialityRepository) 
        {
            _hospitalSpecialityRepository = hospitalSpecialityRepository;
        }


        public async Task<PagedResultDto<HospitalSpecialityDto>> GetAll(GetAllHospitalSpecialityInputDto input)
        {
            var result = new PagedResultDto<HospitalSpecialityDto>();
            try
            {
                var filter = _hospitalSpecialityRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.HospitalSpecialityCodeFilter), x => x.HospitalSpecialityCode == input.HospitalSpecialityCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.HospitalSpecialityNameFilter), x => x.HospitalSpecialityName == input.HospitalSpecialityNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<HospitalSpecialityDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async Task<ResultDto<HospitalSpecialityDto>> Get(Guid id)
        {
            var result = new ResultDto<HospitalSpecialityDto>();
            try
            {
                var entity = await _hospitalSpecialityRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<HospitalSpecialityDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async Task<ResultDto<HospitalSpecialityDto>> CreateOrEdit(HospitalSpecialityDto input)
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

        public async Task<ResultDto<HospitalSpecialityDto>> Create(HospitalSpecialityDto input)
        {
            var result = new ResultDto<HospitalSpecialityDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var branch = ObjectMapper.Map<HospitalSpeciality>(input);

                    await _hospitalSpecialityRepository.InsertAsync(branch);

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

        public async Task<ResultDto<HospitalSpecialityDto>> Update(HospitalSpecialityDto input)
        {
            var result = new ResultDto<HospitalSpecialityDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _hospitalSpecialityRepository.GetAsync(input.Id.GetValueOrDefault());

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

        public async Task<ResultDto<HospitalSpecialityDto>> Delete(Guid id)
        {
            var result = new ResultDto<HospitalSpecialityDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _hospitalSpecialityRepository.Get(id);

                    await _hospitalSpecialityRepository.DeleteAsync(entity);

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
