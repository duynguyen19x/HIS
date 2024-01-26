using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Business.ItemStocks;
using HIS.Utilities.Enums;

namespace HIS.ApplicationService.Business.Pharmaceuticals.ItemStocks
{
    public interface IItemStockService 
    {
        public Task<PagedResultDto<ItemStockDto>> GetAll(GetAllItemStockInput input);
        public Task<PagedResultDto<ItemStockDto>> GetItemByStocks(Guid stockId);
        public Task<PagedResultDto<ItemStockDto>> GetItemStockByStocks(Guid stockId, CommodityTypes? commodityType, bool isGroup = false, bool isAvailableQuantity = false);
    }
}
