using HIS.ApplicationService.Dictionaries.MedicinePricePolicy;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.MedicinePricePolicy;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicinePricePolicyController : ControllerBase
    {
        private readonly ISMedicinePricePolicyService _medicinePricePolicyService;

        public MedicinePricePolicyController(ISMedicinePricePolicyService medicinePricePolicyService)
        {
            _medicinePricePolicyService = medicinePricePolicyService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<MedicinePricePolicyDto>> GetAll([FromQuery] GetAllMedicinePricePolicyInput input)
        {
            return await _medicinePricePolicyService.GetAll(input);
        }
    }
}
