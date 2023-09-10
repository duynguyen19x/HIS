using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Application.Core.Utils;
using HIS.ApplicationService.Business.MedicalRecords;
using HIS.ApplicationService.Business.PatientRecords;
using HIS.ApplicationService.Business.Patients;
using HIS.Core.Linq;
using HIS.Dtos.Business.PatientRecords;
using HIS.Dtos.Business.Patients;
using HIS.Dtos.Business.Receptions;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Receptions
{
    /// <summary>
    /// Xử lý tiếp nhận bệnh nhân.
    /// </summary>
    public class ReceptionAppService : BaseAppService, IReceptionAppService
    {
        private readonly IPatientAppService _patientAppService;
        private readonly IPatientRecordAppService _patientRecordAppService;
        public ReceptionAppService(
            IMedicalRecordAppService medicalRecordAppService,
            IMedicalRecordExamAppService medicalRecordExamAppService,
            IPatientAppService patientAppService,
            IPatientRecordAppService patientRecordAppService,
            HISDbContext context,
            IMapper mapper) 
            : base(context, mapper)
        {
            _patientAppService = patientAppService;
            _patientRecordAppService = patientRecordAppService;
        }


        public async Task<ResultDto<ReceptionDto>> CreateOrEdit(ReceptionDto input)
        {
            if (DataHelper.IsNullOrDefault(input.PatientRecordId))
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ResultDto<ReceptionDto>> Create(ReceptionDto input)
        {
            var result = new ResultDto<ReceptionDto>();
            try
            {
                // 1. thêm mới hoặc cập nhật thông tin định danh bệnh nhân (Patient)
                // 2. thêm mới thông tin điều trị (PatientRecord)
                // 3. thêm mới thông tin đăng ký dịch vụ khám (ServiceReq và ServiceReqServe).
                var patient = ObjectMapper.Map<PatientDto>(input);
                var resultCreateOrEditPatientResult = await _patientAppService.CreateOrEdit(patient);
                if (resultCreateOrEditPatientResult.IsSuccessed)
                {
                    input.PatientId = resultCreateOrEditPatientResult.Item.Id;
                    input.PatientCode = resultCreateOrEditPatientResult.Item.Code;

                    var patientRecord = ObjectMapper.Map<PatientRecordDto>(input);
                    var resultCreateOrEditPatientRecordResult = await _patientRecordAppService.CreateOrEdit(patientRecord);
                    if (resultCreateOrEditPatientRecordResult.IsSuccessed)
                    {




                    }    
                    else
                    {
                        result.IsSuccessed = false;
                        result.Message = resultCreateOrEditPatientResult.Message;
                        result.Errors = resultCreateOrEditPatientResult.Errors;
                    }    
                }  
                else
                {
                    result.IsSuccessed = false;
                    result.Message = resultCreateOrEditPatientResult.Message;
                    result.Errors = resultCreateOrEditPatientResult.Errors;
                }    
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return result;
        }

        public Task<ResultDto<ReceptionDto>> Update(ReceptionDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<ReceptionDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<PagedResultDto<ReceptionDto>> GetAll(ReceptionRequestDto input)
        {
            var result = new PagedResultDto<ReceptionDto>();
            try
            {
                var filter = Context.PatientRecords.AsQueryable()
                    .WhereIf(input.DepartmentId != null, x => x.ReceptionDepartmentId == input.DepartmentId)
                    .WhereIf(input.RoomId != null, x => x.ReceptionRoomId == input.RoomId)
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
