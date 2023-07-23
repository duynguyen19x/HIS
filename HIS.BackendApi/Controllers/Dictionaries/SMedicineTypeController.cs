using HIS.ApplicationService.Dictionaries.MedicineType;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.MedicineType;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMedicineTypeController : ControllerBase
    {
        private readonly ISMedicineTypeService _sMedicineTypeService;

        public SMedicineTypeController(ISMedicineTypeService sMedicineTypeService)
        {
            _sMedicineTypeService = sMedicineTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SMedicineTypeDto>> GetAll([FromQuery] GetAllSMedicineTypeInput input)
        {
            return await _sMedicineTypeService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SMedicineTypeDto>> GetById(Guid id)
        {
            return await _sMedicineTypeService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SMedicineTypeDto>> CreateOrEdit(SMedicineTypeDto input)
        {
            return await _sMedicineTypeService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<SMedicineTypeDto>> Delete(Guid id)
        {
            return await _sMedicineTypeService.Delete(id);
        }
    }
}
