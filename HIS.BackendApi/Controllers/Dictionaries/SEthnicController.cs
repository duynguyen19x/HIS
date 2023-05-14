using HIS.ApplicationService.Dictionaries.Ethnic;
using HIS.ApplicationService.Dictionaries.Career;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Ethnic;
using HIS.Dtos.Dictionaries.Career;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SEthnicController : ControllerBase
    {
        private readonly ISEthnicService _ethnicService;

        public SEthnicController(ISEthnicService ethnicService)
        {
            _ethnicService = ethnicService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SEthnicDto>> GetAll([FromQuery] GetAllSEthnicInput input)
        {
            return await _ethnicService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SEthnicDto>> GetById(Guid id)
        {
            return await _ethnicService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SEthnicDto>> CreateOrEdit(SEthnicDto input)
        {
            return await _ethnicService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<SEthnicDto>> Delete(Guid id)
        {
            return await _ethnicService.Delete(id);
        }
    }
}
