using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Application.Core.Utils;
using HIS.Dtos.Business.PatientRecords;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.PatientRecords
{
    public class PatientRecordAppService : BaseAppService, IPatientRecordAppService
    {
        public PatientRecordAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public virtual async Task<ResultDto<PatientRecordDto>> CreateOrEdit(PatientRecordDto input)
        {
            if (DataHelper.IsNullOrDefault(input.Id))
                return await Create(input);
            else
                return await Update(input); 
        }

        public virtual async Task<ResultDto<PatientRecordDto>> Create(PatientRecordDto input) => await BeginTransactionAsync<ResultDto<PatientRecordDto>>(async result =>
        {
            try
            {
                result.IsSucceeded = false;
                if (DataHelper.IsNullOrDefault(input.PatientId))
                    result.Error(nameof(PatientRecordDto.PatientId), "Mã bệnh nhân không tồn tại!");

                if (!result.HasErrors)
                {
                    input.Id = Guid.NewGuid();
                    if (DataHelper.IsNullOrDefault(input.Code))
                        input.Code = "BA" + String.Format("{0:00000}", Context.PatientRecords.Count() + 1);

                    var patientRecord = ObjectMapper.Map<PatientRecord>(input);
                    patientRecord.CreatedDate = DateTime.Now;
                    patientRecord.CreatedBy = SessionExtensions.Login?.Id;

                    Context.PatientRecords.Add(patientRecord);
                    await SaveChangesAsync();

                    result.Item = input;
                    result.IsSucceeded = true;
                } 
            }
            catch (Exception ex)
            {
                result.Exception(ex);
                throw;
            }
        });

        public virtual async Task<ResultDto<PatientRecordDto>> Update(PatientRecordDto input) => await BeginTransactionAsync<ResultDto<PatientRecordDto>>(async result =>
        {
            try
            {
                result.IsSucceeded = false;
                if (DataHelper.IsNullOrDefault(input.PatientId))
                    result.Error(nameof(PatientRecordDto.PatientId), "Bệnh nhân không tồn tại!");
                if (DataHelper.IsNullOrDefault(input.Id))
                    result.Error(nameof(PatientRecordDto.Id), "Bệnh án không tồn tại!");
                if (DataHelper.IsNullOrDefault(input.Code))
                    result.Error(nameof(PatientRecordDto.Code), "Mã bệnh án không tồn tại!");
                
                if (!result.HasErrors)
                {
                    if (DataHelper.IsNullOrDefault(input.Code))
                        input.Code = "BA" + String.Format("{0:00000}", Context.PatientRecords.Count() + 1);

                    var patientRecord = ObjectMapper.Map<PatientRecord>(input);
                    patientRecord.ModifiedDate = DateTime.Now;
                    patientRecord.ModifiedBy = SessionExtensions.Login?.Id;

                    Context.PatientRecords.Update(patientRecord);
                    await SaveChangesAsync();

                    result.Item = input;
                    result.IsSucceeded = true;
                }
            }
            catch (Exception ex)
            {
                result.Exception(ex);
                throw;
            }
        });

        public virtual async Task<ResultDto<PatientRecordDto>> Delete(Guid id) => await BeginTransactionAsync<ResultDto<PatientRecordDto>>(async result =>
        {
            try
            {
                var patientRecord = Context.PatientRecords.SingleOrDefault(x => x.Id == id);
                if (patientRecord != null)
                {
                    Context.PatientRecords.Remove(patientRecord);
                    await SaveChangesAsync();
                }    
            }
            catch (Exception ex)
            {
                result.Exception(ex);
                throw;
            }
        });

        public virtual Task<PagedResultDto<PatientRecordDto>> GetAll(PagedPatientRecordInputDto input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ResultDto<PatientRecordDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        
    }
}
