using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business;

namespace HIS.ApplicationService.Business
{
    public interface IPatientAppService : IBaseAppService
    {
        Task<PagedResultDto<PatientDto>> GetAll(GetAllPatientInputDto input);
        Task<ResultDto<PatientDto>> GetById(Guid id);
        Task<ResultDto<PatientDto>> CreateOrEdit(PatientDto input);
        //Task<ResultDto<PatientDto>> Create(PatientDto input);
        //Task<ResultDto<PatientDto>> Update(PatientDto input);
        Task<ResultDto<PatientDto>> Delete(Guid id);
    }
}
