using HIS.ApplicationService.Business.Pharmaceuticals.DMedicineStock;
using HIS.Dtos.Business.DMedicineStock;
using HIS.Dtos.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Business.Pharmaceuticals
{
    [Route("api/[controller]")]
    [ApiController]
    public class DMedicineStockController : ControllerBase
    {
        private readonly IDMedicineStockService _dMedicineStockService;

        public DMedicineStockController(IDMedicineStockService dMedicineStockService)
        {
            _dMedicineStockService = dMedicineStockService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<DMedicineStockDto>> GetAll([FromQuery] GetAllDMedicineStockInput input)
        {
            return await _dMedicineStockService.GetAll(input);
        }
    }
}
