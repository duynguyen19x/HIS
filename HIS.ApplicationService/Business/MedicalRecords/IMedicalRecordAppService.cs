using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.MedicalRecords;
using HIS.Dtos.Business.PatientRecords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.MedicalRecords
{
    public interface IMedicalRecordAppService : IBaseAppService
    {
        Task<ResultDto<MedicalRecordDto>> CreateOrEdit(MedicalRecordDto input);
        Task<ResultDto<MedicalRecordDto>> Delete(Guid id);
        Task<PagedResultDto<MedicalRecordDto>> GetAll(MedicalRecordRequestDto input);
        Task<ResultDto<MedicalRecordDto>> GetById(Guid id);
    }
}
