using HIS.ApplicationService.Dictionaries.MedicineType;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.MedicineType;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineTypeController : ControllerBase
    {
        private readonly IMedicineTypeService _sMedicineTypeService;

        public MedicineTypeController(IMedicineTypeService sMedicineTypeService)
        {
            _sMedicineTypeService = sMedicineTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<MedicineTypeDto>> GetAll([FromQuery] GetAllMedicineTypeInput input)
        {
            return await _sMedicineTypeService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<MedicineTypeDto>> GetById(Guid id)
        {
            return await _sMedicineTypeService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<MedicineTypeDto>> CreateOrEdit(MedicineTypeDto input)
        {
            return await _sMedicineTypeService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<MedicineTypeDto>> Delete(Guid id)
        {
            return await _sMedicineTypeService.Delete(id);
        }
    }
}
