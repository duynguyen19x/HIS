using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Business.PatientRecord;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.PatientRecord
{
    public class PatientRecordAppService : BaseCrudAppService, IPatientRecordAppService
    {
        public PatientRecordAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async Task<PagedResultDto<PatientRecordDto>> GetAll(GetAllPatientRecordInputDto input)
        {
            var result = new PagedResultDto<PatientRecordDto>();
            try
            {
            }
            catch (Exception ex)
            {
                result.IsSuccessed = true;
                result.Message = ex.Message;
            }
            return await Task.FromResult(result);
        }

        public async Task<ResultDto<PatientRecordDto>> GetById(Guid id)
        {
            var result = new ResultDto<PatientRecordDto>();
            try
            {
            }
            catch (Exception ex)
            {
                result.IsSuccessed = true;
                result.Message = ex.Message;
            }
            return await Task.FromResult(result);
        }

        public Task<ResultDto<PatientRecordDto>> Create(PatientRecordDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<PatientRecordDto>> Update(PatientRecordDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<PatientRecordDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
