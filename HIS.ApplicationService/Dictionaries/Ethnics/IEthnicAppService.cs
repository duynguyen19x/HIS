using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.Ethnics;

namespace HIS.ApplicationService.Dictionaries.Ethnics
{
    public interface IEthnicAppService : IBaseCrudAppService<EthnicDto, Guid, GetAllEthnicInputDto>
    {

    }
}
