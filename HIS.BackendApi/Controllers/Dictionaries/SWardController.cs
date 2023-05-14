using HIS.ApplicationService.Dictionaries.Career;
using HIS.ApplicationService.Dictionaries.Ward;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Career;
using HIS.Dtos.Dictionaries.Ward;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SWardController : ControllerBase
    {
        private readonly ISWardService _wardService;

        public SWardController(ISWardService wardService)
        {
            _wardService = wardService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SWardDto>> GetAll([FromQuery] GetAllSWardInput input)
        {
            return await _wardService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SWardDto>> GetById(Guid id)
        {
            return await _wardService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SWardDto>> CreateOrEdit(SWardDto input)
        {
            return await _wardService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<SWardDto>> Delete(Guid id)
        {
            return await _wardService.Delete(id);
        }
    }
}
