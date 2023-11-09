using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Application.Core.Utils;
using HIS.ApplicationService.Business.MedicalRecords;
using HIS.ApplicationService.Business.PatientRecords;
using HIS.ApplicationService.Business.Patients;
using HIS.ApplicationService.Business.ServiceRequests;
using HIS.Core.Linq;
using HIS.Dtos.Business.PatientRecords;
using HIS.Dtos.Business.Patients;
using HIS.Dtos.Business.Receptions;
using HIS.Dtos.Business.ServiceRequests;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;

namespace HIS.ApplicationService.Business.Receptions
{
    /// <summary>
    /// Xử lý tiếp nhận bệnh nhân.
    /// </summary>
    public class ReceptionAppService : BaseAppService, IReceptionAppService
    {
        private readonly IPatientAppService _patientAppService;
        private readonly IPatientRecordAppService _patientRecordAppService;
        private readonly IMedicalRecordAppService _medicalRecordAppService;
        private readonly IMedicalRecordExamAppService _medicalRecordExamAppService;
        private readonly IServiceRequestAppService _serviceRequestAppService;

        public ReceptionAppService(
            IMedicalRecordAppService medicalRecordAppService,
            IMedicalRecordExamAppService medicalRecordExamAppService,
            IPatientAppService patientAppService,
            IPatientRecordAppService patientRecordAppService,
            IServiceRequestAppService serviceReqAppService,
            HISDbContext context,
            IMapper mapper) 
            : base(context, mapper)
        {
            _patientAppService = patientAppService;
            _patientRecordAppService = patientRecordAppService;
            _medicalRecordAppService = medicalRecordAppService;
            _medicalRecordExamAppService = medicalRecordExamAppService;
            _serviceRequestAppService = serviceReqAppService;
        }


        public async Task<ResultDto<ReceptionDto>> CreateOrEdit(ReceptionDto input)
        {
            if (DataHelper.IsNullOrDefault(input.Id))
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ResultDto<ReceptionDto>> Create(ReceptionDto input)
        {
            var result = new ResultDto<ReceptionDto>();
            var dateNow = DateTime.Now;
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var patient = ObjectMapper.Map<Patient>(input);
                    patient.Id = input.PatientId.GetValueOrDefault();
                    if (DataHelper.IsNullOrDefault(patient.Id))
                    {
                        patient.Id = Guid.NewGuid();
                        patient.Code = "BN" + dateNow.Year + String.Format("{0:000}", Context.Patients.Count() + 1);
                        patient.CreatedDate = dateNow;
                        patient.CreatedBy = SessionExtensions.Login?.Id;
                        Context.Patients.Add(patient);
                    }
                    else
                    {
                        Context.Patients.Update(patient);
                    }

                    // thêm mới hồ sơ bệnh án
                    var patientRecord = ObjectMapper.Map<PatientRecord>(input);
                    patientRecord.PatientId = patient.Id;
                    patientRecord.Code = "BA" + String.Format("{0:000}", Context.PatientRecords.Count() + 1);
                    patientRecord.CreatedDate = dateNow;
                    patientRecord.CreatedBy = SessionExtensions.Login?.Id;
                    Context.PatientRecords.Add(patientRecord);

                    await SaveChangesAsync();
                    transaction.Commit();

                    result.IsSucceeded = true;
                    result.Item = input;
                }
                catch (Exception ex)
                {
                    result.IsSucceeded = false;
                    result.Message = ex.Message;
                }
            }

            return result;
        }

        public async Task<ResultDto<ReceptionDto>> Update(ReceptionDto input) => await BeginTransactionAsync<ResultDto<ReceptionDto>>(async result =>
        {
            try
            {
                var patient = ObjectMapper.Map<PatientDto>(input);
                var resultCreateOrEditPatient = await _patientAppService.CreateOrEdit(patient);
                if (resultCreateOrEditPatient.IsSucceeded)
                {
                    input.PatientId = resultCreateOrEditPatient.Item.Id;
                    input.PatientCode = resultCreateOrEditPatient.Item.Code;

                    var patientRecord = ObjectMapper.Map<PatientRecordDto>(input);
                    var resultCreateOrEditPatientRecord = await _patientRecordAppService.CreateOrEdit(patientRecord);
                    if (resultCreateOrEditPatientRecord.IsSucceeded)
                    {
                        input.PatientRecordId = resultCreateOrEditPatientRecord.Item.Id;
                        input.PatientRecordCode = resultCreateOrEditPatientRecord.Item.Code;

                        var serviceReq = ObjectMapper.Map<ServiceRequestDto>(input);
                        var resultCreateOrEditServiceReq = await _serviceRequestAppService.CreateOrEdit(serviceReq);
                        if (resultCreateOrEditServiceReq.IsSucceeded)
                        {
                            //input.ServiceId =
                        }
                        else
                        {
                            result.IsSucceeded = false;
                            result.Message = resultCreateOrEditServiceReq.Message;
                            result.Errors = resultCreateOrEditServiceReq.Errors;
                        }
                    }
                    else
                    {
                        result.IsSucceeded = false;
                        result.Message = resultCreateOrEditPatientRecord.Message;
                        result.Errors = resultCreateOrEditPatientRecord.Errors;
                    }
                }
                else
                {
                    result.IsSucceeded = false;
                    result.Message = resultCreateOrEditPatient.Message;
                    result.Errors = resultCreateOrEditPatient.Errors;
                }

                await SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Exception(ex);
                throw;
            }
        });

        public Task<ResultDto<ReceptionDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<PagedResultDto<ReceptionDto>> GetAll(PagedReceptionInputDto input)
        {
            var result = new PagedResultDto<ReceptionDto>();
            try
            {
                var filter = Context.PatientRecords.AsQueryable()
                    //.WhereIf(input.DepartmentId != null, x => x.ReceptionDepartmentId == input.DepartmentId)
                    //.WhereIf(input.RoomId != null, x => x.ReceptionRoomId == input.RoomId)
                    .WhereIf(input.ReceptionFromDate != null, x => x.ReceptionDate >= input.ReceptionFromDate)
                    .WhereIf(input.ReceptionToDate != null, x => x.ReceptionDate <= input.ReceptionToDate);

                var paged = await filter.PageBy(input).ToListAsync();
                var totalCount = await filter.CountAsync();

                result.Items = ObjectMapper.Map<IList<ReceptionDto>>(paged);
                result.TotalCount = totalCount;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return result;
        }

        public virtual async Task<ResultDto<ReceptionDto>> GetById(Guid id)
        {
            var result = new ResultDto<ReceptionDto>();
            try
            {
                result.Item = ObjectMapper.Map<ReceptionDto>(await Context.PatientRecords.FindAsync(id));
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }
    }
}
