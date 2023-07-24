using HIS.ApplicationService.Dictionaries.MedicineLine;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.MedicineLine;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMedicineLineController : ControllerBase
    {
        private readonly ISMedicineLineService _medicineLineService;

        public SMedicineLineController(ISMedicineLineService medicineLineService)
        {
            _medicineLineService = medicineLineService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<MedicineLineDto>> GetAll([FromQuery] GetAllSMedicineLineInput input)
        {
            return await _medicineLineService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<MedicineLineDto>> GetById(Guid id)
        {
            return await _medicineLineService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<MedicineLineDto>> CreateOrEdit(MedicineLineDto input)
        {
            return await _medicineLineService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<MedicineLineDto>> Delete(Guid id)
        {
            return await _medicineLineService.Delete(id);
        }
    }
}
