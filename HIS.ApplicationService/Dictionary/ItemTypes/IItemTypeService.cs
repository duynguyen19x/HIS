using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.ItemTypes;

namespace HIS.ApplicationService.Dictionaries.ItemTypes
{
    public interface IItemTypeService : IAppService
    {
        Task<ResultDto<ItemTypeDto>> CreateOrEdit(ItemTypeDto input);
        Task<ResultDto<ItemTypeDto>> Delete(Guid id);
        Task<PagedResultDto<ItemTypeDto>> GetAll(GetAllItemTypeInput input);
        Task<ResultDto<ItemTypeDto>> GetById(Guid id);

        Task<ResultDto<bool>> Import(IList<ItemTypeDto> input);
    }
}
