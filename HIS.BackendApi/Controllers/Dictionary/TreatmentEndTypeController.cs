using HIS.ApplicationService.Dictionary.InvoiceGroups;
using HIS.ApplicationService.Dictionary.InvoiceGroups.Dto;
using HIS.ApplicationService.Dictionary.TreatmentEndTypes;
using HIS.ApplicationService.Dictionary.TreatmentEndTypes.Dto;
using HIS.Core.Application.Services.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionary
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentEndTypeController : ControllerBase
    {
        private readonly ITreatmentEndTypeAppService _treatmentEndTypeAppService;

        public TreatmentEndTypeController(ITreatmentEndTypeAppService treatmentEndTypeAppService)
        {
            _treatmentEndTypeAppService = treatmentEndTypeAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<TreatmentEndTypeDto>> GetAll([FromQuery] GetAllTreatmentEndTypeInputDto input)
        {
            return await _treatmentEndTypeAppService.GetAll(input);
        }
    }
}
