using HIS.ApplicationService.Dictionaries.Wards;
using HIS.Dtos.Dictionaries.Ward;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class WardController : ControllerBase
    {
        private readonly IWardAppService _wardService;

        public WardController(IWardAppService wardService)
        {
            _wardService = wardService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<WardDto>> GetAll([FromQuery] GetAllWardInput input)
        {
            return await _wardService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<WardDto>> GetById(Guid id)
        {
            return await _wardService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<WardDto>> CreateOrEdit(WardDto input)
        {
            return await _wardService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<WardDto>> Delete(Guid id)
        {
            return await _wardService.Delete(id);
        }
    }
}
