using HIS.ApplicationService.Business.MedicalRecords.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.MedicalRecords
{
    public class MedicalRecordAppService : BaseAppService, IMedicalRecordAppService
    {

        public MedicalRecordAppService() 
        { 
        }

        public Task<ResultDto<MedicalRecordDto>> CreateOrEdit(MedicalRecordDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<MedicalRecordDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<MedicalRecordDto>> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<MedicalRecordDto>> GetAll(GetAllMedicalRecordInputDto input)
        {
            throw new NotImplementedException();
        }
    }
}
