using HIS.ApplicationService.Dictionaries.ServicePricePolicy;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SServicePricePolicyController : ControllerBase
    {
        private readonly ISServicePricePolicyService _sServicePricePolicyService;

        public SServicePricePolicyController(ISServicePricePolicyService sServicePricePolicyService)
        {
            _sServicePricePolicyService = sServicePricePolicyService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SServicePricePolicyDto>> GetAll([FromQuery] GetAllSServicePricePolicyInput input)
        {
            return await _sServicePricePolicyService.GetAll(input);
        }
    }
}
