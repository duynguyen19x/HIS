using HIS.ApplicationService.Dictionaries.SurgicalProcedureType;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Service;
using HIS.Dtos.Dictionaries.SurgicalProcedureType;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SSurgicalProcedureTypeController : ControllerBase
    {
        private readonly ISurgicalProcedureTypeService _surgicalProcedureTypeService;

        public SSurgicalProcedureTypeController(ISurgicalProcedureTypeService surgicalProcedureTypeService)
        {
            _surgicalProcedureTypeService = surgicalProcedureTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SSurgicalProcedureTypeDto>> GetAll([FromQuery] GetAllSSurgicalProcedureTypeInput input)
        {
            return await _surgicalProcedureTypeService.GetAll(input);
        }
    }
}
