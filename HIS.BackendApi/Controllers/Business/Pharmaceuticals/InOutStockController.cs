using HIS.ApplicationService.Business.Pharmaceuticals.InOutStocks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Business.InOutStocks.Dto;

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
        [Authorize]
        public async Task<ListResultDto<InOutStockDto>> GetByStocks(Guid stockId, string fromDate, string toDate)
        {
            return await _inOutStockService.GetByStocks(stockId, fromDate, toDate);
        }

        #region Nhập thuốc từ NCC
        [HttpGet("ImportFromSupplierGetById")]
        [Authorize]
        public async Task<ResultDto<InOutStockDto>> ImportFromSupplierGetById(Guid id)
        {
            return await _inOutStockService.ImportFromSupplierGetById(id);
        }

        [HttpPost("ImportFromSupplierCanceled")]
        [Authorize]
        public async Task<ResultDto<InOutStockDto>> ImportFromSupplierCanceled(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromSupplierCanceled(input);
        }

        [HttpPost("ImportFromSupplierSaveAsDraft")]
        [Authorize]
        public async Task<ResultDto<InOutStockDto>> ImportFromSupplierSaveAsDraft(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromSupplierSaveAsDraft(input);
        }

        [HttpPost("ImportFromSupplierStockIn")]
        [Authorize]
        public async Task<ResultDto<InOutStockDto>> ImportFromSupplierStockIn(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromSupplierStockIn(input);
        }

        [HttpDelete("ImportFromSupplierDeleted")]
        [Authorize]
        public async Task<ResultDto<bool>> ImportFromSupplierDeleted(Guid id)
        {
            return await _inOutStockService.ImportFromSupplierDeleted(id);
        }
        #endregion

        #region Nhập chuyển kho
        [Authorize]
        [HttpGet("ImportFromAnotherStockGetById")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockGetById(Guid id)
        {
            return await _inOutStockService.ImportFromAnotherStockGetById(id);
        }

        [Authorize]
        [HttpPost("ImportFromAnotherStockSaveAsDraft")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockSaveAsDraft(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockSaveAsDraft(input);
        }

        [Authorize]
        [HttpPost("ImportFromAnotherStockRequest")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockRequest(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockRequest(input);
        }

        [Authorize]
        [HttpPost("ImportFromAnotherStockCancelRequest")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockCancelRequest(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockCancelRequest(input);
        }

        [Authorize]
        [HttpPost("ImportFromAnotherStockApproved")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockApproved(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockApproved(input);
        }

        [Authorize]
        [HttpPost("ImportFromAnotherStockCancelApproved")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockCancelApproved(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockCancelApproved(input);
        }

        [Authorize]
        [HttpPost("ImportFromAnotherStockStockOut")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockStockOut(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockStockOut(input);
        }

        [Authorize]
        [HttpPost("ImportFromAnotherStockCanCelStockOut")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockCanCelStockOut(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockCanCelStockOut(input);
        }

        [Authorize]
        [HttpPost("ImportFromAnotherStockStockIn")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockStockIn(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockStockIn(input);
        }

        [Authorize]
        [HttpPost("ImportFromAnotherStockCancelStockIn")]
        public async Task<ResultDto<InOutStockDto>> ImportFromAnotherStockCancelStockIn(InOutStockDto input)
        {
            return await _inOutStockService.ImportFromAnotherStockCancelStockIn(input);
        }

        [Authorize]
        [HttpDelete("ImportFromAnotherStockDeleted")]
        public async Task<ResultDto<bool>> ImportFromAnotherStockDeleted(Guid id)
        {
            return await _inOutStockService.ImportFromAnotherStockDeleted(id);
        }
        #endregion

        #region Xuất trả nhà cung cấp
        [Authorize]
        [HttpGet("ExportToSupplierGetById")]
        public async Task<ResultDto<InOutStockDto>> ExportToSupplierGetById(Guid id)
        {
            return await _inOutStockService.ExportToSupplierGetById(id);
        }

        [Authorize]
        [HttpPost("ExportToSupplierSaveAsDraft")]
        public async Task<ResultDto<InOutStockDto>> ExportToSupplierSaveAsDraft(InOutStockDto input)
        {
            return await _inOutStockService.ExportToSupplierSaveAsDraft(input);
        }

        [Authorize]
        [HttpPost("ExportToSupplierStockOut")]
        public async Task<ResultDto<InOutStockDto>> ExportToSupplierStockOut(InOutStockDto input)
        {
            return await _inOutStockService.ExportToSupplierStockOut(input);
        }

        [Authorize]
        [HttpPost("ExportToSupplierCanCelStockOut")]
        public async Task<ResultDto<InOutStockDto>> ExportToSupplierCanCelStockOut(InOutStockDto input)
        {
            return await _inOutStockService.ExportToSupplierCanCelStockOut(input);
        }

        [Authorize]
        [HttpDelete("ExportToSupplierDeleted")]
        public async Task<ResultDto<bool>> ExportToSupplierDeleted(Guid id)
        {
            return await _inOutStockService.ExportToSupplierDeleted(id);
        }
        #endregion
    }
}
