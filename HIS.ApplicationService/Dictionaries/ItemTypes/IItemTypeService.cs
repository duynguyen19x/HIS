using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.ItemTypes;
using HIS.Models.Commons;

namespace HIS.ApplicationService.Dictionaries.ItemTypes
{
    public interface IItemTypeService : IBaseDictionaryService<ItemTypeDto, GetAllItemTypeInput>
    {
        Task<ApiResult<bool>> Import(IList<ItemTypeDto> input);
    }
}
