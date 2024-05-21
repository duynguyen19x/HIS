using HIS.ApplicationService.Business.MedicalRecords.Dto;
using HIS.ApplicationService.Business.Receptions.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.MedicalRecords
{
    public interface IMedicalRecordAppService : IAppService
    {
        Task<ResultDto<MedicalRecordDto>> Get(Guid id);
        Task<PagedResultDto<MedicalRecordDto>> GetAll(GetAllMedicalRecordInputDto input);
        Task<ResultDto<MedicalRecordDto>> CreateOrEdit(MedicalRecordDto input);
        Task<ResultDto<MedicalRecordDto>> Delete(Guid id);
    }
}
