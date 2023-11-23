using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.Ethnicities;

namespace HIS.ApplicationService.Dictionaries.Ethnicities
{
    public interface IEthnicityAppService : IBaseCrudAppService<EthnicityDto, Guid, GetAllEthnicityInput>
    {

    }
}
