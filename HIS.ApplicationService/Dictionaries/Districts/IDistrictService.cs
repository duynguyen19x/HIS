using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.District;

namespace HIS.ApplicationService.Dictionaries.Districts
{
    public interface IDistrictService : IBaseCrudAppService<DistrictDto, Guid?, GetAllDistrictInput>
    {
    }
}
