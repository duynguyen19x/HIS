using HIS.Core.Services.Dto;
using HIS.ApplicationService.Dictionaries.ServicePricePolicy;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicePricePolicyController : ControllerBase
    {
        private readonly IServicePricePolicyService _sServicePricePolicyService;

        public ServicePricePolicyController(IServicePricePolicyService sServicePricePolicyService)
        {
            _sServicePricePolicyService = sServicePricePolicyService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<ServicePricePolicyDto>> GetAll([FromQuery] GetAllServicePricePolicyInput input)
        {
            return await _sServicePricePolicyService.GetAll(input);
        }
    }
}
