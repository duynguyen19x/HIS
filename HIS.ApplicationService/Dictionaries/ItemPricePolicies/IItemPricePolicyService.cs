using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.ItemPricePolicies;

namespace HIS.ApplicationService.Dictionaries.ItemPricePolicies
{
    public interface IItemPricePolicyService : IBaseDictionaryService<ItemPricePolicyDto, GetAllItemPricePolicyInput, Guid>
    {
         
    }
}
