using HIS.Core.Application.Services.Dto;
using HIS.Core.Application.Services;
using Microsoft.AspNetCore.Mvc;
using HIS.ApplicationService.Dictionary.Ethnics;
using HIS.ApplicationService.Dictionary.Ethnics.Dto;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class EthnicController : ControllerBase
    {
        private readonly IEthnicAppService _ethnicAppService;

        public EthnicController(IEthnicAppService ethnicAppService) 
        {
            _ethnicAppService = ethnicAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<EthnicDto>> GetAll([FromQuery] GetAllEthnicInputDto input)
        {
            return await _ethnicAppService.GetAllAsync(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<EthnicDto>> GetById(Guid id)
        {
            return await _ethnicAppService.GetAsync(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<EthnicDto>> CreateOrEdit(EthnicDto input)
        {
            return await _ethnicAppService.CreateOrUpdateAsync(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<EthnicDto>> Delete(Guid id)
        {
            return await _ethnicAppService.DeleteAsync(id);
        }
    }
}
