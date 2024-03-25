using HIS.ApplicationService.Business.PatientRecords.Dto;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Business.PatientRecords
{
    public interface IPatientRecordAppService 
    {
        Task<PagedResultDto<PatientRecordDto>> GetAllAsync(GetAllPatientRecordInputDto input);

        Task<ResultDto<PatientRecordDto>> GetAsync(Guid id);

        Task<ResultDto<PatientRecordDto>> CreateOrUpdateAsync(PatientRecordDto input);

        Task<ResultDto<PatientRecordDto>> DeleteAsync(Guid id);
    }
}
