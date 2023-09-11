using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.PatientRecords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.PatientRecords
{
    public interface IPatientRecordAppService : IBaseAppService
    {
        Task<ResultDto<PatientRecordDto>> CreateOrEdit(PatientRecordDto input);
        Task<ResultDto<PatientRecordDto>> Delete(Guid id);
        Task<PagedResultDto<PatientRecordDto>> GetAll(PagedPatientRecordInputDto input);
        Task<ResultDto<PatientRecordDto>> GetById(Guid id);
    }
}
