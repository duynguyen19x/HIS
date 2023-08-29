using HIS.ApplicationService.Dictionaries.MedicineGroup;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.MedicineGroup;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineGroupController : ControllerBase
    {
        private readonly IMedicineGroupService _sMedicineGroupService;

        public MedicineGroupController(IMedicineGroupService sMedicineGroupService)
        {
            _sMedicineGroupService = sMedicineGroupService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<MedicineGroupDto>> GetAll([FromQuery] GetAllMedicineGroupInput input)
        {
            return await _sMedicineGroupService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<MedicineGroupDto>> GetById(Guid id)
        {
            return await _sMedicineGroupService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<MedicineGroupDto>> CreateOrEdit(MedicineGroupDto input)
        {
            return await _sMedicineGroupService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<MedicineGroupDto>> Delete(Guid id)
        {
            return await _sMedicineGroupService.Delete(id);
        }
    }
}
