using HIS.ApplicationService.Business.MedicalRecords.Dto;
using HIS.ApplicationService.Business.Patients;
using HIS.ApplicationService.Business.Patients.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HIS.ApplicationService.Business.MedicalRecords
{
    public class MedicalRecordAppService : BaseAppService, IMedicalRecordAppService
    {
        private readonly IRepository<MedicalRecord, Guid> _medicalRecordRepository;
        private readonly IPatientAppService _patientAppService;

        public MedicalRecordAppService(
            IRepository<MedicalRecord, Guid> medicalRecordRepository,
            IPatientAppService patientAppService) 
        {
            _medicalRecordRepository = medicalRecordRepository;
            _patientAppService = patientAppService;
        }

        public async Task<PagedResultDto<MedicalRecordDto>> GetAll(GetAllMedicalRecordInputDto input)
        {
            var result = new PagedResultDto<MedicalRecordDto>();
            try
            {
                var filter = _medicalRecordRepository.GetAll()
                    .WhereIf(!Check.IsNullOrDefault(input.PatientFilter), x => x.PatientID == input.PatientFilter)
                    .WhereIf(!Check.IsNullOrDefault(input.MaxMedicalRecordDateFilter), x => x.MedicalRecordDate <= input.MaxMedicalRecordDateFilter)
                    .WhereIf(!Check.IsNullOrDefault(input.MinMedicalRecordDateFilter), x => x.MedicalRecordDate >= input.MinMedicalRecordDateFilter)
                    .WhereIf(!Check.IsNullOrDefault(input.MedicalRecordCodeFilter), x => x.MedicalRecordCode != null && x.MedicalRecordCode.Contains(input.MedicalRecordCodeFilter))
                    .WhereIf(!Check.IsNullOrDefault(input.MedicalRecordTypeFilter), x => x.MedicalRecordTypeID == input.MedicalRecordTypeFilter)
                    .WhereIf(!Check.IsNullOrDefault(input.MedicalRecordStatusFilter), x => x.MedicalRecordStatusID == input.MedicalRecordStatusFilter);

                var paged = filter.ApplySortingAndPaging(input, nameof(MedicalRecord.MedicalRecordCode));

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<MedicalRecordDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async Task<ResultDto<MedicalRecordDto>> Get(Guid id)
        {
            var result = new ResultDto<MedicalRecordDto>();
            try
            {
                var medicalRecord = await _medicalRecordRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<MedicalRecordDto>(medicalRecord);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        

        public async Task<ResultDto<MedicalRecordDto>> CreateOrEdit(MedicalRecordDto input)
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

        public async Task<ResultDto<MedicalRecordDto>> Create(MedicalRecordDto input)
        {
            var result = new ResultDto<MedicalRecordDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var patient = ObjectMapper.Map<PatientDto>(input);
                    var patientResult = await _patientAppService.CreateOrEdit(patient);
                    if (patientResult.IsSucceeded)
                    {
                        patient = patientResult.Result;
                    }
                    else
                    {
                        throw new Exception(patientResult.Message);
                    }

                    if (Check.IsNullOrDefault(input.Id))
                        input.Id = Guid.NewGuid();
                    input.PatientName = patient.PatientName;
                    input.PatientID = patient.Id;

                    var medicalRecord = ObjectMapper.Map<MedicalRecord>(input);

                    await _medicalRecordRepository.InsertAsync(medicalRecord);

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

        public async Task<ResultDto<MedicalRecordDto>> Update(MedicalRecordDto input)
        {
            var result = new ResultDto<MedicalRecordDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var medicalRecord = await _medicalRecordRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, medicalRecord);
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

        public async Task<ResultDto<MedicalRecordDto>> Delete(Guid id)
        {
            var result = new ResultDto<MedicalRecordDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                try
                {
                    var medicalRecord = _medicalRecordRepository.Get(id);
                    if (medicalRecord.MedicalRecordStatusID > 0)
                    {
                        throw new Exception("Bệnh án đã kết thúc!");
                    }

                    await _medicalRecordRepository.DeleteAsync(medicalRecord);

                    result.Result = ObjectMapper.Map<MedicalRecordDto>(medicalRecord);
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
