using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Business.ItemStocks;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Items;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Utilities.Enums;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace HIS.ApplicationService.Business.Pharmaceuticals.ItemStocks
{
    public class ItemStockService : BaseSerivce, IItemStockService
    {
        public ItemStockService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
          : base(dbContext, config, mapper) { }

        public async Task<ApiResultList<ItemStockDto>> GetAll(GetAllItemStockInput input)
        {
            var result = new ApiResultList<ItemStockDto>();

            try
            {
                result.Result = (from mediStock in _dbContext.ItemStocks
                                 join stock in _dbContext.Rooms on mediStock.StockId equals stock.Id
                                 join Item in _dbContext.Items on mediStock.ItemId equals Item.Id
                                 select new ItemStockDto()
                                 {
                                     Id = mediStock.Id,
                                     ItemId = mediStock.ItemId,
                                     StockId = mediStock.StockId,
                                     AvailableQuantity = mediStock.AvailableQuantity,
                                     Quantity = mediStock.Quantity,

                                     ItemCode = Item.Code,
                                     ItemName = Item.Name,
                                     StockCode = stock.Code,
                                     StockName = stock.Name,
                                     CommodityType = Item.CommodityType
                                 })
                                 .WhereIf(!GuidHelper.IsNullOrEmpty(input.StockIdFilter), w => w.StockId == input.StockIdFilter)
                                 .WhereIf(!GuidHelper.IsNullOrEmpty(input.ItemIdFilter), w => w.ItemId == input.ItemIdFilter)
                                 .WhereIf(input.CommodityTypeFilter != null, w => w.CommodityType == input.CommodityTypeFilter)
                                 .OrderBy(o => o.StockCode).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResultList<ItemStockDto>> GetItemByStocks(Guid stockId)
        {
            var result = new ApiResultList<ItemStockDto>();

            try
            {
                result.Result = (from dItemStock in _dbContext.ItemStocks
                                 join sItem in _dbContext.Items on dItemStock.ItemId equals sItem.Id

                                 where dItemStock.IsDeleted == false
                                    && dItemStock.AvailableQuantity > 0
                                    && dItemStock.StockId == stockId

                                 select new ItemStockDto()
                                 {
                                     Id = dItemStock.Id,
                                     ItemCode = sItem.Code,
                                     ItemName = sItem.Name,
                                     StockId = dItemStock.StockId,
                                     ItemId = dItemStock.ItemId,
                                     Quantity = dItemStock.Quantity,
                                     AvailableQuantity = dItemStock.AvailableQuantity,
                                     Item = _mapper.Map<ItemDto>(sItem)
                                 }).ToList();
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }
    }
}
