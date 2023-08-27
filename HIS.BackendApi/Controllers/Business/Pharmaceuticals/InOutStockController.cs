using HIS.ApplicationService.Business.InOutStockType;
using HIS.ApplicationService.Business.Pharmaceuticals.InOutStock;
using HIS.Dtos.Business.InOutStock;
using HIS.Dtos.Commons;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HIS.BackendApi.Controllers.Business.Pharmaceuticals
{
    [Route("api/[controller]")]
    [ApiController]
    public class InOutStockController : ControllerBase
    {
        private readonly IInOutStockService _inOutStockService;

        public InOutStockController(IInOutStockService inOutStockService)
        {
            _inOutStockService = inOutStockService;
        }

        [HttpGet("GetByStocks")]
        public async Task<ApiResultList<InOutStockDto>> GetByStocks(Guid stockId, string fromDate, string toDate)
        {
             return await _inOutStockService.GetByStocks(stockId, fromDate, toDate);
        }

        #region Nhập thuốc từ NCC
        [HttpGet("ImportFromSupplierGetById")]
        public async Task<ApiResult<InOutStockDto>> ImportFromSupplierGetById(Guid id)
        {
            return await _inOutStockService.ImportFromSupplierGetById(id);
        }
        [HttpPost("ImportFromSupplierCanceled")]
        public async Task<ApiResult<InOutStockDto>> ImportFromSupplierCanceled(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromSupplierCanceled(input);
        }
        [HttpPost("ImportFromSupplierSaveAsDraft")]
        public async Task<ApiResult<InOutStockDto>> ImportFromSupplierSaveAsDraft(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromSupplierSaveAsDraft(input);
        }
        [HttpPost("ImportFromSupplierStockIn")]
        public async Task<ApiResult<InOutStockDto>> ImportFromSupplierStockIn(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromSupplierStockIn(input);
        }
        [HttpDelete("ImportFromSupplierDeleted")]
        public async Task<ApiResult<bool>>  ImportFromSupplierDeleted(Guid id)
        {
            return await _inOutStockService.ImportFromSupplierDeleted(id);
        }
        #endregion

        #region Nhập chuyển kho
        [HttpGet("ImportFromAnotherStockGetById")]
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockGetById(Guid id)
        {
            return await _inOutStockService.ImportFromAnotherStockGetById(id);
        }
        [HttpPost("ImportFromAnotherStockSaveAsDraft")]
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockSaveAsDraft(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockSaveAsDraft(input);
        }
        [HttpPost("ImportFromAnotherStockRequest")]
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockRequest(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockRequest(input);
        }
        [HttpPost("ImportFromAnotherStockStockIn")]
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockStockIn(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockStockIn(input);
        }
        #endregion
    }
}
