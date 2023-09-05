using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.PatientRecords;

namespace HIS.ApplicationService.Business.Receptions
{
    public interface IReceptionAppService : IBaseAppService
    {
        Task<ResultDto<PatientRecordDto>> CreateOrEdit(PatientRecordDto input);
        Task<ResultDto<PatientRecordDto>> Delete(Guid id);
        Task<PagedResultDto<PatientRecordDto>> GetAll(PatientRecordRequestDto input);
        Task<ResultDto<PatientRecordDto>> GetById(Guid id);
    }
}
