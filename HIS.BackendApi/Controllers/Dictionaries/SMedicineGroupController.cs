using HIS.ApplicationService.Dictionaries.Branch;
using HIS.ApplicationService.Dictionaries.MedicineGroup;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Branch;
using HIS.Dtos.Dictionaries.MedicineGroup;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMedicineGroupController : ControllerBase
    {
        private readonly ISMedicineGroupService _sMedicineGroupService;

        public SMedicineGroupController(ISMedicineGroupService sMedicineGroupService)
        {
            _sMedicineGroupService = sMedicineGroupService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SMedicineGroupDto>> GetAll([FromQuery] GetAllSMedicineGroupInput input)
        {
            return await _sMedicineGroupService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SMedicineGroupDto>> GetById(Guid id)
        {
            return await _sMedicineGroupService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SMedicineGroupDto>> CreateOrEdit(SMedicineGroupDto input)
        {
            return await _sMedicineGroupService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<SMedicineGroupDto>> Delete(Guid id)
        {
            return await _sMedicineGroupService.Delete(id);
        }
    }
}
