using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.ApplicationService.Business.MedicalRecords;
using HIS.ApplicationService.Business.PatientRecords;
using HIS.ApplicationService.Business.Patients;
using HIS.Core.Linq;
using HIS.Dtos.Business.PatientRecords;
using HIS.Dtos.Business.Patients;
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


        public async Task<ResultDto<PatientRecordDto>> CreateOrEdit(PatientRecordDto input)
        {
            if (input.PatientRecordId == default(Guid))
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ResultDto<PatientRecordDto>> Create(PatientRecordDto input)
        {
            return await BeginTransactionAsync<ResultDto<PatientRecordDto>>(async result =>
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
                    result = await _patientRecordAppService.CreateOrEdit(input);
                    if (result.IsSuccessed)
                    {
                        input = result.Item;
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

        public Task<ResultDto<PatientRecordDto>> Update(PatientRecordDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<PatientRecordDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<PagedResultDto<PatientRecordDto>> GetAll(PatientRecordRequestDto input)
        {
            var result = new PagedResultDto<PatientRecordDto>();
            try
            {
                var filter = Context.PatientRecords.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.PatientRecordCodeFilter), x => x.Code.ToLower() == input.PatientRecordCodeFilter.ToLower())
                    ;
                var paged = await filter.PageBy(input).ToListAsync();
                var totalCount = await filter.CountAsync();

                result.Items = Mapper.Map<IList<PatientRecordDto>>(paged);
                result.TotalCount = totalCount;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return result;
        }

        public virtual async Task<ResultDto<PatientRecordDto>> GetById(Guid id)
        {
            var result = new ResultDto<PatientRecordDto>();
            try
            {
                result.Item = Mapper.Map<PatientRecordDto>(await Context.PatientRecords.FindAsync(id));
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }
    }
}
