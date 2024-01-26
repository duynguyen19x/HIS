using HIS.Application.Core.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Business.PatientRecords;
using HIS.Dtos.Business.Patients;

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
