using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.ServiceGroup;

namespace HIS.ApplicationService.Dictionaries.ServiceGroup
{
    public interface IServiceGroupService : IBaseCrudAppService<ServiceGroupDto, Guid, GetAllServiceGroupInput>
    {
    }
}
