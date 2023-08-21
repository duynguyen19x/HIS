using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business;

namespace HIS.ApplicationService.Business
{
    public interface IPatientRecordAppService : IBaseAppService
    {
        Task<PagedResultDto<PatientRecordDto>> GetAll(GetAllPatientRecordInputDto input);
        Task<ResultDto<PatientRecordDto>> GetById(Guid id);
        Task<ResultDto<PatientRecordDto>> CreateOrEdit(PatientRecordDto input);
        Task<ResultDto<PatientRecordDto>> Delete(Guid id);
    }
}
