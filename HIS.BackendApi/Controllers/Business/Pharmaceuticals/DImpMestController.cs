using HIS.ApplicationService.Business.Pharmaceuticals.DImpMests;
using HIS.Dtos.Business.InOutStock;
using HIS.Dtos.Business.DMedicineStock;
using HIS.Dtos.Commons;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Business.Pharmaceuticals
{
    [Route("api/[controller]")]
    [ApiController]
    public class DImpMestController : ControllerBase
    {
        private readonly IDImpMestService _dImpMestService;

        public DImpMestController(IDImpMestService dImpMestService)
        {
            _dImpMestService = dImpMestService;
        }

        [HttpGet("GetByStocks")]
        public async Task<ApiResultList<InOutStockDto>> GetByStocks(Guid stockId, string fromDate, string toDate)
        {
            return await _dImpMestService.GetByStocks(stockId, fromDate, toDate);
        }

        #region Nhập từ NCC
        [HttpPost("ImportFromSupplierSaveAsDraft")]
        public async Task<ApiResult<InOutStockDto>> ImportFromSupplierSaveAsDraft(InOutStockDto input)
        {
            return await _dImpMestService.ImportFromSupplierSaveAsDraft(input);
        }

        [HttpPost("ImportFromSupplierStockIn")]
        public async Task<ApiResult<InOutStockDto>> ImportFromSupplierStockIn(InOutStockDto input)
        {
            return await _dImpMestService.ImportFromSupplierStockIn(input);
        }

        [HttpGet("ImportFromSupplierGetById")]
        public async Task<ApiResult<InOutStockDto>> ImportFromSupplierGetById(Guid id)
        {
            return await _dImpMestService.ImportFromSupplierGetById(id);
        }

        [HttpGet("ImportFromSupplierCanceled")]
        public async Task<ApiResult<bool>> ImportFromSupplierCanceled(Guid id)
        {
            return await _dImpMestService.ImportFromSupplierCanceled(id);
        }
        #endregion

        #region Nhập từ kho khác
        [HttpGet("ImportFromAnotherStockGetById")]
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockGetById(Guid id)
        {
            return await _dImpMestService.ImportFromAnotherStockGetById(id);
        }

        [HttpPost("ImportFromAnotherStockSaveAsDraft")]
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockSaveAsDraft(InOutStockDto input)
        {
            return await _dImpMestService.ImportFromAnotherStockSaveAsDraft(input);
        }

        [HttpPost("ImportFromAnotherStockRequest")]
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockRequest(InOutStockDto input)
        {
            return await _dImpMestService.ImportFromAnotherStockRequest(input);
        }

        [HttpPost("ImportFromAnotherStockStockIn")]
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockStockIn(InOutStockDto input)
        {
            return await _dImpMestService.ImportFromAnotherStockStockIn(input);
        }
        #endregion
    }
}
