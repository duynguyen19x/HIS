using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.ItemPricePolicies;

namespace HIS.ApplicationService.Dictionary.ItemPricePolicies
{
    public interface IItemPricePolicyService : IAppService
    {
        Task<ResultDto<ItemPricePolicyDto>> CreateOrEdit(ItemPricePolicyDto input);
        Task<ResultDto<ItemPricePolicyDto>> Delete(Guid id);
        Task<PagedResultDto<ItemPricePolicyDto>> GetAll(GetAllItemPricePolicyInput input);
        Task<ResultDto<ItemPricePolicyDto>> GetById(Guid id);
    }
}
