using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Business.Patient;
using HIS.Models.Commons;

namespace HIS.ApplicationService.Business.Patient
{
    public interface IPatientAppService : IBaseAppService
    {
        Task<PagedResultDto<PatientDto>> GetAll(GetAllPatientInputDto input);
        Task<ResultDto<PatientDto>> GetById(Guid id);
        Task<ResultDto<PatientDto>> Create(PatientDto input);
        Task<ResultDto<PatientDto>> Update(PatientDto input);
        Task<ResultDto<PatientDto>> Delete(Guid id);
    }
}
