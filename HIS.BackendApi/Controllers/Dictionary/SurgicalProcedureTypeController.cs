using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Dictionary.SurgicalProcedureTypes.Dto;
using HIS.ApplicationService.Dictionary.SurgicalProcedureTypes;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurgicalProcedureTypeController : ControllerBase
    {
        private readonly ISurgicalProcedureTypeAppService _surgicalProcedureTypeService;

        public SurgicalProcedureTypeController(ISurgicalProcedureTypeAppService surgicalProcedureTypeService)
        {
            _surgicalProcedureTypeService = surgicalProcedureTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<SSurgicalProcedureTypeDto>> GetAll([FromQuery] GetAllSurgicalProcedureTypeInput input)
        {
            return await _surgicalProcedureTypeService.GetAll(input);
        }
    }
}
