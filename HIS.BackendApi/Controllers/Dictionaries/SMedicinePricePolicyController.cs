using HIS.ApplicationService.Dictionaries.MedicineLine;
using HIS.ApplicationService.Dictionaries.MedicinePricePolicy;
using HIS.ApplicationService.Dictionaries.ServicePricePolicy;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.MedicineLine;
using HIS.Dtos.Dictionaries.MedicinePricePolicy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMedicinePricePolicyController : ControllerBase
    {
        private readonly ISMedicinePricePolicyService _medicinePricePolicyService;

        public SMedicinePricePolicyController(ISMedicinePricePolicyService medicinePricePolicyService)
        {
            _medicinePricePolicyService = medicinePricePolicyService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SMedicinePricePolicyDto>> GetAll([FromQuery] GetAllSMedicinePricePolicyInput input)
        {
            return await _medicinePricePolicyService.GetAll(input);
        }
    }
}
