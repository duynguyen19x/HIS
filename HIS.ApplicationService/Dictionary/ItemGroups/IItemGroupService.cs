using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.ItemGroups;

namespace HIS.ApplicationService.Dictionaries.ItemGroups
{
    public interface IItemGroupService : IAppService
    {
        Task<ResultDto<ItemGroupDto>> CreateOrEdit(ItemGroupDto input);
        Task<ResultDto<ItemGroupDto>> Delete(Guid id);
        Task<PagedResultDto<ItemGroupDto>> GetAll(GetAllItemGroupInput input);
        Task<ResultDto<ItemGroupDto>> GetById(Guid id);
    }
}
