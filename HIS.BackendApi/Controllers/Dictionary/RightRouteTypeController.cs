using HIS.ApplicationService.Dictionaries.RightRouteTypes;
using HIS.ApplicationService.Dictionary.RightRouteTypes.Dto;
using HIS.ApplicationService.Dictionary.Rooms.Dto;
using HIS.Core.Application.Services.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace HIS.BackendApi.Controllers.Dictionary
{
    [Route("api/[controller]")]
    [ApiController]
    public class RightRouteTypeController : ControllerBase
    {
        private readonly IRightRouteTypeAppService _rightRouteTypeAppService;

        public RightRouteTypeController(IRightRouteTypeAppService rightRouteTypeAppService)
        {
            _rightRouteTypeAppService = rightRouteTypeAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<RightRouteTypeDto>> GetAll([FromQuery] GetAllRightRouteTypeInputDto input)
        {
            return await _rightRouteTypeAppService.GetAll(input); 
        }
    }
}
