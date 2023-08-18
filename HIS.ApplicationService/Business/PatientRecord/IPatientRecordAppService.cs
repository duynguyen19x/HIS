using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Business.Patient;
using HIS.Dtos.Business.PatientRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.PatientRecord
{
    public interface IPatientRecordAppService : IBaseAppService
    {
        Task<PagedResultDto<PatientRecordDto>> GetAll(GetAllPatientRecordInputDto input);
        Task<ResultDto<PatientRecordDto>> GetById(Guid id);
        Task<ResultDto<PatientRecordDto>> Create(PatientRecordDto input);
        Task<ResultDto<PatientRecordDto>> Update(PatientRecordDto input);
        Task<ResultDto<PatientRecordDto>> Delete(Guid id);
    }
}
