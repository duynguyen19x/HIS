using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.Hospital;

namespace HIS.ApplicationService.Dictionaries.Hospital
{
    public interface IHospitalService : IBaseCrudAppService<HospitalDto, Guid?, GetAllHospitalInput>
    {
    }
}
