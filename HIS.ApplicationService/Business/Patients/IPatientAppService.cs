using HIS.Application.Core.Services;
using HIS.Dtos.Business.Patients;

namespace HIS.ApplicationService.Business.Patients
{
    public interface IPatientAppService : IBaseCrudAppService<PatientDto, Guid, GetAllPatientInputDto>
    {
    }
}
