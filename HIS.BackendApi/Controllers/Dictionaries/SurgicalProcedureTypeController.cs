using HIS.ApplicationService.Dictionaries.SurgicalProcedureType;
using HIS.Dtos.Dictionaries.SurgicalProcedureType;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurgicalProcedureTypeController : ControllerBase
    {
        private readonly ISurgicalProcedureTypeService _surgicalProcedureTypeService;

        public SurgicalProcedureTypeController(ISurgicalProcedureTypeService surgicalProcedureTypeService)
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
