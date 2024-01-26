using HIS.ApplicationService.Business.Pharmaceuticals.ItemStocks;
using HIS.Dtos.Business.ItemStocks;
using HIS.Utilities.Enums;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;

namespace HIS.BackendApi.Controllers.Business.Pharmaceuticals
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemStockController : ControllerBase
    {
        private readonly IItemStockService _dItemStockService;

        public ItemStockController(IItemStockService dItemStockService)
        {
            _dItemStockService = dItemStockService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<ItemStockDto>> GetAll([FromQuery] GetAllItemStockInput input)
        {
            return await _dItemStockService.GetAll(input);
        }

        [HttpGet("GetItemByStocks")]
        public async Task<PagedResultDto<ItemStockDto>> GetItemByStocks(Guid stockId)
        {
            return await _dItemStockService.GetItemByStocks(stockId);
        }

        [HttpGet("GetItemStockByStocks")]
        public async Task<PagedResultDto<ItemStockDto>> GetItemStockByStocks(Guid stockId, CommodityTypes? commodityType, bool isGroup = false, bool isAvailableQuantity = false)
        {
            return await _dItemStockService.GetItemStockByStocks(stockId, commodityType, isGroup, isAvailableQuantity);
        }
    }
}
