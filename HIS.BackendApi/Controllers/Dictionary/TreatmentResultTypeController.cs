using HIS.ApplicationService.Dictionary.TreatmentEndTypes.Dto;
using HIS.ApplicationService.Dictionary.TreatmentEndTypes;
using HIS.Core.Application.Services.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HIS.ApplicationService.Dictionary.TreatmentResultTypes;
using HIS.ApplicationService.Dictionary.TreatmentResultTypes.Dto;

namespace HIS.BackendApi.Controllers.Dictionary
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentResultTypeController : ControllerBase
    {
        private readonly ITreatmentResultTypeAppService _treatmentResultTypeAppService;

        public TreatmentResultTypeController(ITreatmentResultTypeAppService treatmentResultTypeAppService)
        {
            _treatmentResultTypeAppService = treatmentResultTypeAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<TreatmentResultTypeDto>> GetAll([FromQuery] GetAllTreatmentResultTypeInputDto input)
        {
            return await _treatmentResultTypeAppService.GetAll(input);
        }
    }
}
