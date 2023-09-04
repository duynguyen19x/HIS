using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.PatientRecords;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.PatientRecords
{
    public class PatientRecordAppService : BaseCrudAppService<PatientRecordDto, PatientRecordRequestDto>, IPatientRecordAppService
    {
        public PatientRecordAppService(HISDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override Task<ResultDto<PatientRecordDto>> Create(PatientRecordDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<PatientRecordDto>> Update(PatientRecordDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<PatientRecordDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public override Task<PagedResultDto<PatientRecordDto>> GetAll(PatientRecordRequestDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<PatientRecordDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
