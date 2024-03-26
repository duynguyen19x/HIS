using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Dictionary.ServicePricePolicies.Dto;
using HIS.ApplicationService.Dictionary.ServicePricePolicies;

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
