using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.ItemLines;

namespace HIS.ApplicationService.Dictionaries.ItemLines
{
    public interface IItemLineService : IAppService
    {
        Task<ResultDto<ItemLineDto>> CreateOrEdit(ItemLineDto input);
        Task<ResultDto<ItemLineDto>> Delete(Guid id);
        Task<PagedResultDto<ItemLineDto>> GetAll(GetAllItemLineInput input);
        Task<ResultDto<ItemLineDto>> GetById(Guid id);
    }
}
