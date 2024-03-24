using HIS.Core.Application.Services.Dto;
using HIS.Core.Application.Services;
using Microsoft.AspNetCore.Mvc;
using HIS.ApplicationService.Dictionary.Ethnicities;
using HIS.ApplicationService.Dictionary.Ethnicities.Dto;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class EthnicityController : ControllerBase
    {
        private readonly IEthnicityAppService _ethnicityAppService;

        public EthnicityController(IEthnicityAppService ethnicityAppService) 
        {
            _ethnicityAppService = ethnicityAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<EthnicityDto>> GetAll([FromQuery] GetAllEthnicityInputDto input)
        {
            return await _ethnicityAppService.GetAllAsync(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<EthnicityDto>> GetById(Guid id)
        {
            return await _ethnicityAppService.GetAsync(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<EthnicityDto>> CreateOrEdit(EthnicityDto input)
        {
            return await _ethnicityAppService.CreateOrUpdateAsync(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<EthnicityDto>> Delete(Guid id)
        {
            return await _ethnicityAppService.DeleteAsync(id);
        }
    }
}
