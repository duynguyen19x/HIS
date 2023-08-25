using HIS.ApplicationService.Dictionaries.MedicineLine;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.MedicineLine;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineLineController : ControllerBase
    {
        private readonly IMedicineLineService _medicineLineService;

        public MedicineLineController(IMedicineLineService medicineLineService)
        {
            _medicineLineService = medicineLineService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<MedicineLineDto>> GetAll([FromQuery] GetAllMedicineLineInput input)
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
