using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.ItemPricePolicies;

namespace HIS.ApplicationService.Dictionaries.ItemPricePolicies
{
    public interface IItemPricePolicyService : IBaseCrudAppService<ItemPricePolicyDto, Guid?, GetAllItemPricePolicyInput>
    {
         
    }
}
