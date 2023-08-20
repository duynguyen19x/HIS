using HIS.ApplicationService.Business.Pharmaceuticals.DImpMests;
using HIS.Dtos.Business.DImpMest;
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

        [HttpGet("GetByStock")]
        public async Task<ApiResultList<DImpMestDto>> GetByStock(Guid stockId, string fromDate, string toDate)
        {
            return await _dImpMestService.GetByStock(stockId, fromDate, toDate);
        }

        [HttpPost("ImportFromSupplierSaveAsDraft")]
        public async Task<ApiResult<DImpMestDto>> ImportFromSupplierSaveAsDraft(DImpMestDto input)
        {
            return await _dImpMestService.ImportFromSupplierSaveAsDraft(input);
        }

        [HttpPost("ImportFromSupplierStockIn")]
        public async Task<ApiResult<DImpMestDto>> ImportFromSupplierStockIn(DImpMestDto input)
        {
            return await _dImpMestService.ImportFromSupplierStockIn(input);
        }

        [HttpGet("ImportFromSupplierGetById")]
        public async Task<ApiResult<DImpMestDto>> ImportFromSupplierGetById(Guid id)
        {
            return await _dImpMestService.ImportFromSupplierGetById(id);
        }

        [HttpGet("ImportFromSupplierCanceled")]
        public async Task<ApiResult<bool>> ImportFromSupplierCanceled(Guid id)
        {
            return await _dImpMestService.ImportFromSupplierCanceled(id);
        }
    }
}
