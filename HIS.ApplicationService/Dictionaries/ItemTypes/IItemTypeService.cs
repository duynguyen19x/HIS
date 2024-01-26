using HIS.Application.Core.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.ItemTypes;

namespace HIS.ApplicationService.Dictionaries.ItemTypes
{
    public interface IItemTypeService : IBaseCrudAppService<ItemTypeDto, Guid?, GetAllItemTypeInput>
    {
        Task<ResultDto<bool>> Import(IList<ItemTypeDto> input);
    }
}
