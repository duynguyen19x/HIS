using HIS.Dtos.Business.ItemStocks;
using HIS.Dtos.Commons;

namespace HIS.ApplicationService.Business.Pharmaceuticals.ItemStocks
{
    public interface IItemStockService 
    {
        public Task<ApiResultList<ItemStockDto>> GetAll(GetAllItemStockInput input);
        public Task<ApiResultList<ItemStockDto>> GetItemByStocks(Guid stockId);
    }
}
