using HIS.ApplicationService.Business.Pharmaceuticals.ItemStocks;
using HIS.Dtos.Business.ItemStocks;
using HIS.Dtos.Commons;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ApiResultList<ItemStockDto>> GetAll([FromQuery] GetAllItemStockInput input)
        {
            return await _dItemStockService.GetAll(input);
        }

        [HttpGet("GetItemByStocks")]
        public async Task<ApiResultList<ItemStockDto>> GetItemByStocks(Guid stockId)
        {
            return await _dItemStockService.GetItemByStocks(stockId);
        }
    }
}
