using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.Ward;

namespace HIS.ApplicationService.Dictionaries.Wards
{
    public interface IWardAppService : IBaseCrudAppService<WardDto, Guid, GetAllWardInput>
    {
    }
}
