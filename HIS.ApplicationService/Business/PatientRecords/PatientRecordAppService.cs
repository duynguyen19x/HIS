using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Application.Core.Utils;
using HIS.Dtos.Business.PatientRecords;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.PatientRecords
{
    public class PatientRecordAppService : BaseAppService, IPatientRecordAppService
    {
        public PatientRecordAppService(HISDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual async Task<ResultDto<PatientRecordDto>> CreateOrEdit(PatientRecordDto input)
        {
            if (DataHelper.IsNullOrDefault(input.Id))
                return await Create(input);
            else
                return await Update(input); 
        }

        public virtual Task<ResultDto<PatientRecordDto>> Create(PatientRecordDto input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ResultDto<PatientRecordDto>> Update(PatientRecordDto input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ResultDto<PatientRecordDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<PagedResultDto<PatientRecordDto>> GetAll(PagedPatientRecordRequestDto input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ResultDto<PatientRecordDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        
    }
}
