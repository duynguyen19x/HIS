using HIS.Application.Core.Services;
using HIS.Dtos.Business.PatientRecords;

namespace HIS.ApplicationService.Business.PatientRecords
{
    public interface IPatientRecordAppService : IBaseCrudAppService<PatientRecordDto, Guid, GetAllPatientRecordInputDto>
    {
    }
}
