using HIS.ApplicationService.Business.Patients.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Business.Patients
{
    public interface IPatientAppService : IAppService
    {
        Task<ResultDto<PatientDto>> Get(Guid id);
        Task<PagedResultDto<PatientDto>> GetAll(GetAllPatientInputDto input);
        Task<ResultDto<PatientDto>> CreateOrEdit(PatientDto input);
        Task<ResultDto<PatientDto>> Delete(Guid id);
    }
}
