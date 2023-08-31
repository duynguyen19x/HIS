using HIS.ApplicationService.Business.Pharmaceuticals.InOutStock;
using HIS.Dtos.Business.InOutStocks;
using HIS.Dtos.Commons;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ApiResult<bool>> ImportFromSupplierDeleted(Guid id)
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
        [HttpPost("ImportFromAnotherStockCancelRequest")]
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockCancelRequest(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockCancelRequest(input);
        }
        [HttpPost("ImportFromAnotherStockApproved")]
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockApproved(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockApproved(input);
        }
        [HttpPost("ImportFromAnotherStockCancelApproved")]
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockCancelApproved(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockCancelApproved(input);
        }
        [HttpPost("ImportFromAnotherStockStockOut")]
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockStockOut(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockStockOut(input);
        }
        [HttpPost("ImportFromAnotherStockCanCelStockOut")]
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockCanCelStockOut(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockCanCelStockOut(input);
        }
        [HttpPost("ImportFromAnotherStockStockIn")]
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockStockIn(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockStockIn(input);
        }
        [HttpPost("ImportFromAnotherStockCancelStockIn")]
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockCancelStockIn(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockCancelStockIn(input);
        }
        [HttpDelete("ImportFromAnotherStockDeleted")]
        public async Task<ApiResult<bool>> ImportFromAnotherStockDeleted(Guid id)
        {
            return await _inOutStockService.ImportFromAnotherStockDeleted(id);
        }
        #endregion
    }
}
