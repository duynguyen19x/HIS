using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.ItemGroups;

namespace HIS.ApplicationService.Dictionaries.ItemGroups
{
    public interface IItemGroupService : IBaseCrudAppService<ItemGroupDto, Guid?, GetAllItemGroupInput>
    {
        
    }
}
