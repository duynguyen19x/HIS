using HIS.Application.Core.Services.Dto;
using HIS.ApplicationService.Dictionaries.RelativeTypes;
using HIS.Dtos.Dictionaries.RelativeTypes;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelativeTypeController : ControllerBase
    {
        private readonly IRelativeTypeAppService _relativeTypeAppService;

        public RelativeTypeController(IRelativeTypeAppService relativeTypeAppService)
        {
            _relativeTypeAppService = relativeTypeAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<RelativeTypeDto>> GetAll([FromQuery] PagedRelativeTypeInputDto input)
        {
            return await _relativeTypeAppService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<RelativeTypeDto>> GetById(Guid id)
        {
            return await _relativeTypeAppService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<RelativeTypeDto>> CreateOrEdit(RelativeTypeDto input)
        {
            return await _relativeTypeAppService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<RelativeTypeDto>> Delete(Guid id)
        {
            return await _relativeTypeAppService.Delete(id);
        }
    }
}
