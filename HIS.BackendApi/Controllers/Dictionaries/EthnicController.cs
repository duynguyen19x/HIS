using HIS.ApplicationService.Dictionaries.Ethnic;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Ethnic;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class EthnicController : ControllerBase
    {
        private readonly IEthnicService _ethnicService;

        public EthnicController(IEthnicService ethnicService)
        {
            _ethnicService = ethnicService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<EthnicDto>> GetAll([FromQuery] GetAllEthnicInput input)
        {
            return await _ethnicService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<EthnicDto>> GetById(Guid id)
        {
            return await _ethnicService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<EthnicDto>> CreateOrEdit(EthnicDto input)
        {
            return await _ethnicService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<EthnicDto>> Delete(Guid id)
        {
            return await _ethnicService.Delete(id);
        }
    }
}
