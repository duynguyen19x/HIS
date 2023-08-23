using HIS.ApplicationService.Business.Pharmaceuticals.DExpMests;
using HIS.ApplicationService.Business.Pharmaceuticals.DImpMests;
using HIS.Dtos.Business.DExpMest;
using HIS.Dtos.Business.DImpMest;
using HIS.Dtos.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
