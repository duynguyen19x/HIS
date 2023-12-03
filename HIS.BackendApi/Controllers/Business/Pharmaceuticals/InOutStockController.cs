using HIS.Application.Core.Services.Dto;
using HIS.ApplicationService.Business.Pharmaceuticals.InOutStocks;
using HIS.Dtos.Business.InOutStocks;
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
        public async Task<PagedResultDto<InOutStockDto>> GetByStocks(Guid stockId, string fromDate, string toDate)
        {
            return await _inOutStockService.GetByStocks(stockId, fromDate, toDate);
        }

        #region Nhập thuốc từ NCC
        [HttpGet("ImportFromSupplierGetById")]
        public async Task<ResultDto<InOutStockDto>> ImportFromSupplierGetById(Guid id)
        {
            return await _inOutStockService.ImportFromSupplierGetById(id);
        }
        [HttpPost("ImportFromSupplierCanceled")]
        public async Task<ResultDto<InOutStockDto>> ImportFromSupplierCanceled(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromSupplierCanceled(input);
        }
        [HttpPost("ImportFromSupplierSaveAsDraft")]
        public async Task<ResultDto<InOutStockDto>> ImportFromSupplierSaveAsDraft(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromSupplierSaveAsDraft(input);
        }
        [HttpPost("ImportFromSupplierStockIn")]
        public async Task<ResultDto<InOutStockDto>> ImportFromSupplierStockIn(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromSupplierStockIn(input);
        }
        [HttpDelete("ImportFromSupplierDeleted")]
        public async Task<ResultDto<bool>> ImportFromSupplierDeleted(Guid id)
        {
            return await _inOutStockService.ImportFromSupplierDeleted(id);
        }
        #endregion

        #region Nhập chuyển kho
        [HttpGet("ImportFromAnotherStockGetById")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockGetById(Guid id)
        {
            return await _inOutStockService.ImportFromAnotherStockGetById(id);
        }
        [HttpPost("ImportFromAnotherStockSaveAsDraft")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockSaveAsDraft(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockSaveAsDraft(input);
        }
        [HttpPost("ImportFromAnotherStockRequest")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockRequest(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockRequest(input);
        }
        [HttpPost("ImportFromAnotherStockCancelRequest")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockCancelRequest(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockCancelRequest(input);
        }
        [HttpPost("ImportFromAnotherStockApproved")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockApproved(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockApproved(input);
        }
        [HttpPost("ImportFromAnotherStockCancelApproved")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockCancelApproved(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockCancelApproved(input);
        }
        [HttpPost("ImportFromAnotherStockStockOut")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockStockOut(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockStockOut(input);
        }
        [HttpPost("ImportFromAnotherStockCanCelStockOut")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockCanCelStockOut(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockCanCelStockOut(input);
        }
        [HttpPost("ImportFromAnotherStockStockIn")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockStockIn(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockStockIn(input);
        }
        [HttpPost("ImportFromAnotherStockCancelStockIn")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockCancelStockIn(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockCancelStockIn(input);
        }
        [HttpDelete("ImportFromAnotherStockDeleted")]
        public async Task<ResultDto<bool>> ImportFromAnotherStockDeleted(Guid id)
        {
            return await _inOutStockService.ImportFromAnotherStockDeleted(id);
        }
        #endregion
    }
}
