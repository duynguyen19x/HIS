using HIS.ApplicationService.Business.InOutStockType;
using HIS.Dtos.Business.InOutStockType;
using HIS.Dtos.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Business.Pharmaceuticals
{
    [Route("api/[controller]")]
    [ApiController]
    public class DImpExpMestTypeController : ControllerBase
    {
        private readonly IInOutStockTypeService _inOutStockTypeService;

        public DImpExpMestTypeController(IInOutStockTypeService inOutStockTypeService)
        {
            _inOutStockTypeService = inOutStockTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<InOutStockTypeDto>> GetAll([FromQuery] GetAllInOutStockTypeInput input)
        {
            return await _inOutStockTypeService.GetAll(input);
        }
    }
}
