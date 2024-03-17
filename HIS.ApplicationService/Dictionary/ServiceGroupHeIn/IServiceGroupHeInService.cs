using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.ServiceGroupHeIn;

namespace HIS.ApplicationService.Dictionaries.ServiceGroupHeIn
{
    public interface IServiceGroupHeInService : IBaseCrudAppService<ServiceGroupHeInDto, Guid, GetAllServiceGroupHeInInput>
    {
    }
}
