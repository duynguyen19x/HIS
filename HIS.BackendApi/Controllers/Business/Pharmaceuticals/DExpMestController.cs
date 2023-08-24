using HIS.ApplicationService.Business.Pharmaceuticals.DExpMests;
using HIS.ApplicationService.Business.Pharmaceuticals.DImpMests;
using HIS.Dtos.Business.DExpMest;
using HIS.Dtos.Business.DImpMest;
using HIS.Dtos.Commons;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HIS.BackendApi.Controllers.Business.Pharmaceuticals
{
    [Route("api/[controller]")]
    [ApiController]
    public class DExpMestController : ControllerBase
    {
        private readonly IDExpMestService _dExpMestService;

        public DExpMestController(IDExpMestService dExpMestService)
        {
            _dExpMestService = dExpMestService;
        }

        [HttpGet("GetByStocks")]
        public async Task<ApiResultList<DExpMestDto>> GetByStocks(Guid stockId, string fromDate, string toDate)
        {
            return await _dExpMestService.GetByStocks(stockId, fromDate, toDate);
        }

        [HttpGet("ExpFromAnotherStockGetById")]
        public async Task<ApiResult<DExpMestDto>> ExpFromAnotherStockGetById(Guid id)
        {
            return await _dExpMestService.ExpFromAnotherStockGetById(id);
        }
    }
}
