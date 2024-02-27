using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Business.Patients;

namespace HIS.ApplicationService.Business.Patients
{
    public interface IHISPatientAppService : IAppService
    {
        Task<PagedResultDto<HISPatientDto>> GetAllAsync(GetAllHISPatientInputDto input);

        Task<ResultDto<HISPatientDto>> GetAsync(Guid id);

        Task<ResultDto<HISPatientDto>> CreateOrUpdateAsync(HISPatientDto input);

        Task<ResultDto<HISPatientDto>> DeleteAsync(Guid id);
    }
}
