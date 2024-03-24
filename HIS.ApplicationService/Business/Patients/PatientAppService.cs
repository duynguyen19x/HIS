using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.Dtos.Business.Patients;
using HIS.Dtos.Systems;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace HIS.ApplicationService.Business.Patients
{
    public class PatientAppService : HIS.Core.Application.Services.BaseAppService, IPatientAppService
    {
        private readonly IRepository<Patient, Guid> _hisPatientRepository;

        public PatientAppService(
            IRepository<Patient, Guid> hisPatientRepository) 
        {
            _hisPatientRepository = hisPatientRepository;
        }

        public virtual async Task<PagedResultDto<HISPatientDto>> GetAllAsync(GetAllHISPatientInputDto input)
        {
            var result = new PagedResultDto<HISPatientDto>();
            try
            {
                var filter = _hisPatientRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.PatientCodeFilter), x => x.PatientCode == input.PatientCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.PatientNameFilter), x => x.PatientName == input.PatientNameFilter)
                    .WhereIf(input.MaxBirthYear != null, x => x.BirthYear <= input.MaxBirthYear)
                    .WhereIf(input.MinBirthYear != null, x => x.BirthYear >= input.MinBirthYear)
                    .WhereIf(input.MaxBirthDate != null, x => x.BirthDate <= input.MaxBirthDate)
                    .WhereIf(input.MinBirthDate != null, x => x.BirthDate >= input.MinBirthDate)
                    .WhereIf(!string.IsNullOrEmpty(input.BirthplaceFilter), x => x.Birthplace == input.BirthplaceFilter)
                    .WhereIf(input.GenderFilter != null, x => x.GenderId == input.GenderFilter)
                    .WhereIf(input.EthnicFilter != null, x => x.EthnicId == input.EthnicFilter)
                    .WhereIf(input.ReligionFilter != null, x => x.ReligionId == input.ReligionFilter)
                    .WhereIf(input.CountryFilter != null, x => x.CountryId == input.CountryFilter)
                    .WhereIf(input.ProvinceFilter != null, x => x.ProvinceId == input.ProvinceFilter)
                    .WhereIf(input.DistrictFilter != null, x => x.DistrictId == input.DistrictFilter)
                    .WhereIf(input.WardFilter != null, x => x.WardId == input.WardFilter)
                    .WhereIf(input.CareerFilter != null, x => x.CareerId == input.CareerFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.WorkplaceFilter), x => x.Workplace == input.WorkplaceFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.IdentificationNumberFilter), x => x.IdentificationNumber == input.IdentificationNumberFilter)
                    .WhereIf(input.MaxIssueDateFilter != null, x => x.IssueDate <= input.MaxIssueDateFilter)
                    .WhereIf(input.MinIssueDateFilter != null, x => x.IssueDate >= input.MinIssueDateFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.IssueByFilter), x => x.IssueBy == input.IssueByFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.TelFilter), x => x.Tel == input.TelFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.MobileFilter), x => x.Mobile == input.MobileFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.EmailFilter), x => x.Email == input.EmailFilter);

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<HISPatientDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<HISPatientDto>> GetAsync(Guid id)
        {
            var result = new ResultDto<HISPatientDto>();
            try
            {
                var data = await _hisPatientRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<HISPatientDto>(data);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<HISPatientDto>> CreateOrUpdateAsync(HISPatientDto input)
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

        public virtual async Task<ResultDto<HISPatientDto>> CreateAsync(HISPatientDto input)
        {
            var result = new ResultDto<HISPatientDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<Patient>(input);
                    entity.CreatedDate = DateTime.Now;

                    await _hisPatientRepository.InsertAsync(entity);
                    unitOfWork.Complete();

                    result.IsSucceeded = true;
                    result.Result = input;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<HISPatientDto>> UpdateAsync(HISPatientDto input)
        {
            var result = new ResultDto<HISPatientDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _hisPatientRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);
                    unitOfWork.Complete();

                    result.Result = ObjectMapper.Map<HISPatientDto>(entity);
                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<HISPatientDto>> DeleteAsync(Guid id)
        {
            var result = new ResultDto<HISPatientDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                try
                {
                    var entity = _hisPatientRepository.Get(id);
                    await _hisPatientRepository.DeleteAsync(entity);

                    result.Result = ObjectMapper.Map<HISPatientDto>(entity);
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
