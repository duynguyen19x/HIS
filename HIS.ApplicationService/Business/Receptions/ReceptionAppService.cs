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
        private readonly IMedicalRecordAppService _medicalRecordAppService;
        private readonly IMedicalRecordExamAppService _medicalRecordExamAppService;
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
            _medicalRecordAppService = medicalRecordAppService;
            _medicalRecordExamAppService = medicalRecordExamAppService;
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
            return await BeginTransactionAsync<ResultDto<ReceptionDto>>(async result =>
            {
                try
                {
                    // validate

                    // thông tin định danh bệnh nhân.
                    var createOrUpdatePatientResult = await _patientAppService.CreateOrEdit(Mapper.Map<PatientDto>(input));
                    if (createOrUpdatePatientResult.IsSuccessed)
                    {
                        input.PatientId = createOrUpdatePatientResult.Item.PatientId;
                    }
                    else
                    {
                        result.IsSuccessed = false;
                        result.Message = createOrUpdatePatientResult.Message;
                        result.Errors = createOrUpdatePatientResult.Errors;
                        return;
                    }

                    // thông tin điều trị.
                    var createOrUpdatePatientRecordResult = await _patientRecordAppService.CreateOrEdit(Mapper.Map<PatientRecordDto>(input));
                    if (createOrUpdatePatientRecordResult.IsSuccessed)
                    {
                        input.PatientRecordId = createOrUpdatePatientRecordResult.Item.PatientRecordId;
                    }
                    else
                        return;

                    // thông tin bệnh án khoa + khám bệnh.

                    // thông tin dịch vụ.


                    await SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            });
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
                    .WhereIf(input.DepartmentId != null, x => x.ReceiptionDepartmentID == input.DepartmentId)
                    .WhereIf(input.RoomId != null, x => x.ReceiptionRoomID == input.RoomId)
                    .WhereIf(input.ReceptionFromDate != null, x => x.ReceiptionDate >= input.ReceptionFromDate)
                    .WhereIf(input.ReceptionToDate != null, x => x.ReceiptionDate <= input.ReceptionToDate);

                var paged = await filter.PageBy(input).ToListAsync();
                var totalCount = await filter.CountAsync();

                result.Items = Mapper.Map<IList<ReceptionDto>>(paged);
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
                result.Item = Mapper.Map<ReceptionDto>(await Context.PatientRecords.FindAsync(id));
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }
    }
}
