using HIS.ApplicationService.Business.Patients.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Business.Patients
{
    public interface IPatientAppService : IAppService
    {
        Task<PagedResultDto<PatientDto>> GetAllAsync(GetAllPatientInputDto input);

        Task<ResultDto<PatientDto>> GetAsync(Guid id);

        Task<ResultDto<PatientDto>> CreateOrUpdateAsync(PatientDto input);

        Task<ResultDto<PatientDto>> DeleteAsync(Guid id);
    }
}
