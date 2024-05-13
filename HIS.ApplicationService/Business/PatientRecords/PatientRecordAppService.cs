using HIS.ApplicationService.Business.PatientRecords.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities;
using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Business.PatientRecords
{
    public class PatientRecordAppService :BaseAppService, IPatientRecordAppService
    {
        private readonly IRepository<PatientRecord, Guid> _hisPatientRecordRepository;
        private readonly IRepository<Patient, Guid> _hisPatientRepository;
        private readonly IRepository<MedicalRecord, Guid> _hisMedicalRecordRepository;

        public PatientRecordAppService(
            IRepository<PatientRecord, Guid> hisPatientRecordRepository,
            IRepository<Patient, Guid> hisPatientRepository,
            IRepository<MedicalRecord, Guid> hisMedicalRecordRepository)
        {
            _hisPatientRecordRepository = hisPatientRecordRepository;
            _hisPatientRepository = hisPatientRepository;
            _hisMedicalRecordRepository = hisMedicalRecordRepository;
        }

        //public override async Task<ResultDto<PatientRecordDto>> Create(PatientRecordDto input)
        //{
        //    var result = new ResultDto<PatientRecordDto>();
        //    using (var transaction = Context.BeginTransaction())
        //    {
        //        try
        //        {
        //            // thông tin bệnh nhân
        //            if (input.PatientId != default(Guid))
        //            {
        //                input.PatientId = Guid.NewGuid();
        //                input.PatientCode = "BN";
        //                var patient = ObjectMapper.Map<Patient>(input);
        //                Context.Patients.Add(patient);
        //            }

        //            // hồ sơ bệnh án
        //            input.Id = Guid.NewGuid();
        //            input.PatientRecordStatusId = 0;
        //            input.PatientRecordCode = "BA";
        //            input.PatientRecordDate = DateTime.Now;
        //            var patientRecord = ObjectMapper.Map<PatientRecord>(input);
        //            Context.PatientRecords.Add(patientRecord);

        //            // bệnh án
        //            var medicalRecord = new MedicalRecord();
        //            medicalRecord.Id = Guid.NewGuid();
        //            medicalRecord.PatientRecordId = patientRecord.Id;
        //            medicalRecord.MedicalRecordCode = "";
        //            medicalRecord.MedicalRecordDate = patientRecord.PatientRecordDate;
        //            // lấy theo cấu hình khoa (chưa làm)
        //            // khám bệnh (tiếp đón tại khoa khấm bệnh)
        //            if (medicalRecord.MedicalRecordTypeId == 0) 
        //                medicalRecord.MedicalRecordTypeId = (int)MedicalRecordTypes.KHAMBENH;
        //            medicalRecord.DepartmentId = patientRecord.ClinicalDepartmentId.GetValueOrDefault();
        //            medicalRecord.RoomId = patientRecord.ClinicalRoomId.GetValueOrDefault();
        //            // điều trị (nếu tiếp đón trực tiếp tại khoa điều trị)
        //            // ....
        //            Context.MedicalRecords.Add(medicalRecord);

        //            // dịch vụ
        //            var lstServiceRequest = new List<ServiceRequest>();
        //            var lstServiceRequestData = new List<ServiceRequestData>();
        //            foreach (var dto in input.ServiceRequests)
        //            {
        //                dto.Id = Guid.NewGuid();
        //                dto.ServiceRequestCode = "KB";
        //                //dto.ServiceRequestDate = patientRecord.PatientRecordDate;
        //                //dto.ServiceRequestUseDate = patientRecord.PatientRecordDate;
        //                dto.NumOrder = 1;
        //                dto.PatientRecordId = patientRecord.Id;
        //                dto.MedicalRecordId = medicalRecord.Id;
        //                dto.DepartmentId = patientRecord.DepartmentId;
        //                dto.RoomId = patientRecord.RoomId;
        //                dto.UserId = patientRecord.UserId;
        //                dto.ExecuteDepartmentId = patientRecord.ClinicalDepartmentId.GetValueOrDefault();
        //                dto.ExecuteRoomId = patientRecord.ClinicalRoomId.GetValueOrDefault();
        //                dto.StartUserId = patientRecord.ClinicalUserId;
        //                var serviceRequest = ObjectMapper.Map<ServiceRequest>(dto);
        //                lstServiceRequest.Add(serviceRequest);

        //                foreach (var dataDto in dto.ServiceRequestDatas)
        //                {
        //                    dataDto.Id = Guid.NewGuid();
        //                    dataDto.ServiceRequestId = dto.Id.GetValueOrDefault();
        //                    var serviceRequestData = ObjectMapper.Map<ServiceRequestData>(dataDto);
        //                    lstServiceRequestData.Add(serviceRequestData);
        //                }    
        //            }
        //            Context.ServiceRequests.AddRange(lstServiceRequest);
        //            Context.ServiceRequestDatas.AddRange(lstServiceRequestData);

        //            result.IsSucceeded = true;
        //            result.Result = input;

        //            await Context.SaveChangesAsync();
        //            transaction.Commit();
        //        }
        //        catch (Exception ex)
        //        {
        //            result.Exception(ex);
        //        } 
                
        //    }
        //    return result;
        //}

        //public override async Task<ResultDto<PatientRecordDto>> Update(PatientRecordDto input)
        //{
        //    var result = new ResultDto<PatientRecordDto>();
        //    using (var transaction = Context.BeginTransaction())
        //    {
        //        try
        //        {
        //            // thông tin bệnh nhân
        //            var patient = ObjectMapper.Map<Patient>(input);
        //            Context.Patients.Update(patient);

        //            // hồ sơ bệnh án
        //            var patientRecord = ObjectMapper.Map<PatientRecord>(input);
        //            Context.PatientRecords.Add(patientRecord);



        //            result.IsSucceeded = true;
        //            result.Result = input;

        //            await Context.SaveChangesAsync();
        //            transaction.Commit();
        //        }
        //        catch (Exception ex)
        //        {
        //            result.Exception(ex);
        //        }

        //    }
        //    return result;
        //}


        public virtual async Task<PagedResultDto<PatientRecordDto>> GetAllAsync(GetAllPatientRecordInputDto input)
        {
            var result = new PagedResultDto<PatientRecordDto>();
            try
            {
                var filter = _hisPatientRecordRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.PatientNameFilter), x => x.Name == input.PatientNameFilter);

                var filterPatient = _hisPatientRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.PatientNameFilter), x => x.PatientName == input.PatientNameFilter);

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<PatientRecordDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<PatientRecordDto>> GetAsync(Guid id)
        {
            var result = new ResultDto<PatientRecordDto>();
            try
            {
                var data = await _hisPatientRecordRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<PatientRecordDto>(data);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<PatientRecordDto>> CreateOrUpdateAsync(PatientRecordDto input)
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

        public virtual Task<ResultDto<PatientRecordDto>> CreateAsync(PatientRecordDto input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ResultDto<PatientRecordDto>> UpdateAsync(PatientRecordDto input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ResultDto<PatientRecordDto>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
