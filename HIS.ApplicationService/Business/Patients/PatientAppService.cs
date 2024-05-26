using HIS.ApplicationService.Business.Patients.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace HIS.ApplicationService.Business.Patients
{
    public class PatientAppService : BaseAppService, IPatientAppService
    {
        private readonly IRepository<Patient, Guid> _patientRepository;
        private readonly IRepository<PatientNumber, Guid> _patientNumberRepository;

        private readonly IPatientNumberAppService _patientNumberAppService;

        public PatientAppService(
            IRepository<Patient, Guid> patientRepository,
            IRepository<PatientNumber, Guid> patientNumberRepository,
            PatientNumberAppService patientNumberAppService) 
        {
            _patientRepository = patientRepository;
            _patientNumberRepository = patientNumberRepository;

            _patientNumberAppService = patientNumberAppService;
        }

        public virtual async Task<PagedResultDto<PatientDto>> GetAll(GetAllPatientInputDto input)
        {
            var result = new PagedResultDto<PatientDto>();
            try
            {
                var filter = _patientRepository.GetAll()
                    .WhereIf(!Check.IsNullOrDefault(input.PatientCodeFilter), x => x.PatientCode.Contains(input.PatientCodeFilter))
                    .WhereIf(!Check.IsNullOrDefault(input.PatientNameFilter), x => x.PatientName.Contains(input.PatientNameFilter))
                    .WhereIf(!Check.IsNullOrDefault(input.MaxBirthDate), x => x.BirthDate <= input.MaxBirthDate)
                    .WhereIf(!Check.IsNullOrDefault(input.MinBirthDate), x => x.BirthDate >= input.MinBirthDate)
                    .WhereIf(!Check.IsNullOrDefault(input.BirthPlaceFilter), x => x.BirthPlace != null && x.BirthPlace.Contains(input.BirthPlaceFilter))
                    .WhereIf(!Check.IsNullOrDefault(input.BloodRhTypeFilter), x => x.BloodRhTypeId == input.BloodRhTypeFilter)
                    .WhereIf(!Check.IsNullOrDefault(input.BloodTypeFilter), x => x.BloodTypeId == input.BloodTypeFilter)
                    .WhereIf(!Check.IsNullOrDefault(input.GenderFilter), x => x.GenderId == input.GenderFilter)
                    .WhereIf(!Check.IsNullOrDefault(input.EthnicityFilter), x => x.EthnicityId == input.EthnicityFilter)
                    .WhereIf(!Check.IsNullOrDefault(input.ReligionFilter), x => x.ReligionId == input.ReligionFilter)
                    .WhereIf(!Check.IsNullOrDefault(input.CountryFilter), x => x.CountryId == input.CountryFilter)
                    .WhereIf(!Check.IsNullOrDefault(input.ProvinceFilter), x => x.ProvinceId == input.ProvinceFilter)
                    .WhereIf(!Check.IsNullOrDefault(input.DistrictFilter), x => x.DistrictId == input.DistrictFilter)
                    .WhereIf(!Check.IsNullOrDefault(input.WardFilter), x => x.WardId == input.WardFilter)
                    .WhereIf(!Check.IsNullOrDefault(input.CareerFilter), x => x.CareerId == input.CareerFilter)
                    .WhereIf(!Check.IsNullOrDefault(input.WorkPlaceFilter), x => x.WorkPlace != null && x.WorkPlace.Contains(input.WorkPlaceFilter))
                    .WhereIf(!Check.IsNullOrDefault(input.AddressFilter), x => x.Address != null && x.Address.Contains(input.AddressFilter))
                    .WhereIf(!Check.IsNullOrDefault(input.PhoneNumberFilter), x => x.PhoneNumber != null && x.PhoneNumber.Contains(input.PhoneNumberFilter))
                    .WhereIf(!Check.IsNullOrDefault(input.EmailFilter), x => x.Email != null && x.Email.Contains(input.EmailFilter))
                    .WhereIf(!Check.IsNullOrDefault(input.IdentificationNumberFilter), x => x.IdentificationNumber != null && x.IdentificationNumber.Contains(input.IdentificationNumberFilter))
                    .WhereIf(!Check.IsNullOrDefault(input.IssueByFilter), x => x.IssueBy != null && x.IssueBy.Contains(input.IssueByFilter))
                    .WhereIf(!Check.IsNullOrDefault(input.ContactNameFilter), x => x.ContactName != null && x.ContactName.Contains(input.ContactNameFilter));

                var paged = filter.ApplySortingAndPaging(input, nameof(Patient.PatientCode));

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<PatientDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<PatientDto>> Get(Guid id)
        {
            var result = new ResultDto<PatientDto>();
            try
            {
                var data = await _patientRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<PatientDto>(data);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<PatientDto>> CreateOrEdit(PatientDto input)
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

        public virtual async Task<ResultDto<PatientDto>> Create(PatientDto input)
        {
            var result = new ResultDto<PatientDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var createdDate = DateTime.Now;
                    var numOrder = 0;

                    input.Id = Guid.NewGuid();
                    input.PatientName = input.PatientName.ToUpper();    

                    // số thứ tự bệnh nhân
                    if (Check.IsNullOrDefault(input.PatientNumberId))
                    {
                        var patientOrderResult = await _patientNumberAppService.CreateLastNumber(createdDate);
                        if (patientOrderResult.IsSucceeded)
                        {
                            input.PatientNumberId = patientOrderResult.Result.Id;
                            numOrder = patientOrderResult.Result.NumOrder;
                        }    
                    }

                    // mã bệnh nhân
                    if (Check.IsNullOrDefault(input.PatientCode))
                    { 
                        input.PatientCode = GetPatientCode(createdDate, numOrder);
                    }    

                    var patient = ObjectMapper.Map<Patient>(input);
                    patient.CreatedDate = createdDate;
                    patient.CreatedBy = SessionExtensions.Login.Id;

                    await _patientRepository.InsertAsync(patient);

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

        public virtual async Task<ResultDto<PatientDto>> Update(PatientDto input)
        {
            var result = new ResultDto<PatientDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _patientRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);
                    unitOfWork.Complete();

                    result.Result = ObjectMapper.Map<PatientDto>(entity);
                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<PatientDto>> Delete(Guid id)
        {
            var result = new ResultDto<PatientDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                try
                {
                    var entity = _patientRepository.Get(id);
                    await _patientRepository.DeleteAsync(entity);

                    result.Result = ObjectMapper.Map<PatientDto>(entity);
                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }



        private string GetPatientCode(DateTime createdDate, int numOrder)
        {
            var year = createdDate.Year % 1000;
            if (year > 100)
                year = year % 100;
            return year.ToString().PadLeft(2, '0') + numOrder.ToString().PadLeft(8, '0');
        }
    }
}
