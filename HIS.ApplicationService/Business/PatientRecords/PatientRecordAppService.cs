using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Enums;
using HIS.Core.Services.Dto;
using HIS.Dtos.Business.PatientRecords;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Business;

namespace HIS.ApplicationService.Business.PatientRecords
{
    public class PatientRecordAppService : BaseCrudAppService<PatientRecordDto, Guid, GetAllPatientRecordInputDto>, IPatientRecordAppService
    {
        public PatientRecordAppService(HISDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public override async Task<ResultDto<PatientRecordDto>> Create(PatientRecordDto input)
        {
            var result = new ResultDto<PatientRecordDto>();
            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    // thông tin bệnh nhân
                    if (input.PatientId != default(Guid))
                    {
                        input.PatientId = Guid.NewGuid();
                        input.PatientCode = "BN";
                        var patient = ObjectMapper.Map<Patient>(input);
                        Context.Patients.Add(patient);
                    }

                    // hồ sơ bệnh án
                    input.Id = Guid.NewGuid();
                    input.PatientRecordStatusId = 0;
                    input.PatientRecordCode = "BA";
                    input.PatientRecordDate = DateTime.Now;
                    var patientRecord = ObjectMapper.Map<PatientRecord>(input);
                    Context.PatientRecords.Add(patientRecord);

                    // bệnh án
                    var medicalRecord = new MedicalRecord();
                    medicalRecord.Id = Guid.NewGuid();
                    medicalRecord.PatientRecordId = patientRecord.Id;
                    medicalRecord.MedicalRecordCode = "";
                    medicalRecord.MedicalRecordDate = patientRecord.PatientRecordDate;
                    // lấy theo cấu hình khoa (chưa làm)
                    // khám bệnh (tiếp đón tại khoa khấm bệnh)
                    if (medicalRecord.MedicalRecordTypeId == 0) 
                        medicalRecord.MedicalRecordTypeId = (int)MedicalRecordTypes.KHAMBENH;
                    medicalRecord.DepartmentId = patientRecord.ClinicalDepartmentId.GetValueOrDefault();
                    medicalRecord.RoomId = patientRecord.ClinicalRoomId.GetValueOrDefault();
                    // điều trị (nếu tiếp đón trực tiếp tại khoa điều trị)
                    // ....
                    Context.MedicalRecords.Add(medicalRecord);

                    // dịch vụ
                    var lstServiceRequest = new List<ServiceRequest>();
                    var lstServiceRequestData = new List<ServiceRequestData>();
                    foreach (var dto in input.ServiceRequests)
                    {
                        dto.Id = Guid.NewGuid();
                        dto.ServiceRequestCode = "KB";
                        //dto.ServiceRequestDate = patientRecord.PatientRecordDate;
                        //dto.ServiceRequestUseDate = patientRecord.PatientRecordDate;
                        dto.NumOrder = 1;
                        dto.PatientRecordId = patientRecord.Id;
                        dto.MedicalRecordId = medicalRecord.Id;
                        dto.DepartmentId = patientRecord.DepartmentId;
                        dto.RoomId = patientRecord.RoomId;
                        dto.UserId = patientRecord.UserId;
                        dto.ExecuteDepartmentId = patientRecord.ClinicalDepartmentId.GetValueOrDefault();
                        dto.ExecuteRoomId = patientRecord.ClinicalRoomId.GetValueOrDefault();
                        dto.ExecuteUserId = patientRecord.ClinicalUserId;
                        var serviceRequest = ObjectMapper.Map<ServiceRequest>(dto);
                        lstServiceRequest.Add(serviceRequest);

                        foreach (var dataDto in dto.ServiceRequestDatas)
                        {
                            dataDto.Id = Guid.NewGuid();
                            dataDto.ServiceRequestId = dto.Id;
                            var serviceRequestData = ObjectMapper.Map<ServiceRequestData>(dataDto);
                            lstServiceRequestData.Add(serviceRequestData);
                        }    
                    }
                    Context.ServiceRequests.AddRange(lstServiceRequest);
                    Context.ServiceRequestDatas.AddRange(lstServiceRequestData);

                    result.IsSucceeded = true;
                    result.Result = input;

                    await Context.SaveChangesAsync();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                } 
                
            }
            return result;
        }

        public override async Task<ResultDto<PatientRecordDto>> Update(PatientRecordDto input)
        {
            var result = new ResultDto<PatientRecordDto>();
            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    // thông tin bệnh nhân
                    var patient = ObjectMapper.Map<Patient>(input);
                    Context.Patients.Update(patient);

                    // hồ sơ bệnh án
                    var patientRecord = ObjectMapper.Map<PatientRecord>(input);
                    Context.PatientRecords.Add(patientRecord);



                    result.IsSucceeded = true;
                    result.Result = input;

                    await Context.SaveChangesAsync();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }

            }
            return result;
        }

        public override async Task<ResultDto<PatientRecordDto>> Delete(Guid id)
        {
            var result = new ResultDto<PatientRecordDto>();
            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    var patientRecord = await Context.PatientRecords.FindAsync(id);
                    patientRecord.IsDeleted = true;
                    Context.PatientRecords.Update(patientRecord);
                    await Context.SaveChangesAsync();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }    
                return result;
        }

        public override async Task<PagedResultDto<PatientRecordDto>> GetAll(GetAllPatientRecordInputDto input)
        {
            var result = new PagedResultDto<PatientRecordDto>();

            result.Result = new List<PatientRecordDto>()
            {
                new PatientRecordDto() { PatientCode = "BN-01", PatientRecordCode = "BA-01", PatientName = "Bệnh nhân 01", BirthDate = DateTime.Now },
                new PatientRecordDto() { PatientCode = "BN-02", PatientRecordCode = "BA-02", PatientName = "Bệnh nhân 02", BirthDate = DateTime.Now },
                new PatientRecordDto() { PatientCode = "BN-03", PatientRecordCode = "BA-03", PatientName = "Bệnh nhân 03", BirthDate = DateTime.Now },
                new PatientRecordDto() { PatientCode = "BN-04", PatientRecordCode = "BA-04", PatientName = "Bệnh nhân 04", BirthDate = DateTime.Now },
                new PatientRecordDto() { PatientCode = "BN-05", PatientRecordCode = "BA-05", PatientName = "Bệnh nhân 05", BirthDate = DateTime.Now },
                new PatientRecordDto() { PatientCode = "BN-06", PatientRecordCode = "BA-06", PatientName = "Bệnh nhân 06", BirthDate = DateTime.Now }
            };
            result.TotalCount = 6;
            return result;
        }

        public override Task<ResultDto<PatientRecordDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        
    }
}
