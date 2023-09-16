using HIS.Dtos.Business.ItemStocks;
using HIS.Dtos.Commons;
using HIS.Utilities.Enums;

namespace HIS.ApplicationService.Business.Pharmaceuticals.ItemStocks
{
    public interface IItemStockService 
    {
        public Task<ApiResultList<ItemStockDto>> GetAll(GetAllItemStockInput input);
        public Task<ApiResultList<ItemStockDto>> GetItemByStocks(Guid stockId);
        public Task<ApiResultList<ItemStockDto>> GetItemStockByStocks(Guid stockId, CommodityTypes? commodityType, bool isGroup = false);
    }
}
