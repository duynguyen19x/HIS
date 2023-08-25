using HIS.ApplicationService.Dictionaries.Ward;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Ward;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class WardController : ControllerBase
    {
        private readonly IWardService _wardService;

        public WardController(IWardService wardService)
        {
            _wardService = wardService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<WardDto>> GetAll([FromQuery] GetAllWardInput input)
        {
            return await _wardService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<WardDto>> GetById(Guid id)
        {
            return await _wardService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<WardDto>> CreateOrEdit(WardDto input)
        {
            return await _wardService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<WardDto>> Delete(Guid id)
        {
            return await _wardService.Delete(id);
        }
    }
}
