using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Business.InOutStockTypes;
using HIS.ApplicationService.Business.InOutStockTypes.Dto;

namespace HIS.BackendApi.Controllers.Business.Pharmaceuticals
{
    [Route("api/[controller]")]
    [ApiController]
    public class InOutStockTypeController : ControllerBase
    {
        private readonly IInOutStockTypeService _inOutStockTypeService;

        public InOutStockTypeController(IInOutStockTypeService inOutStockTypeService)
        {
            _inOutStockTypeService = inOutStockTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<InOutStockTypeDto>> GetAll([FromQuery] GetAllInOutStockTypeInput input)
        {
            return await _inOutStockTypeService.GetAll(input);
        }
    }
}
