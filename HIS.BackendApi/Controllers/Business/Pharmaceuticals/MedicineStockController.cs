using HIS.ApplicationService.Business.Pharmaceuticals.MedicineStock;
using HIS.Dtos.Business.MedicineStocks;
using HIS.Dtos.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Business.Pharmaceuticals
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineStockController : ControllerBase
    {
        private readonly IMedicineStockService _dMedicineStockService;

        public MedicineStockController(IMedicineStockService dMedicineStockService)
        {
            _dMedicineStockService = dMedicineStockService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<MedicineStockDto>> GetAll([FromQuery] GetAllMedicineStockInput input)
        {
            return await _dMedicineStockService.GetAll(input);
        }

        [HttpGet("GetMedicineByStocks")]
        public async Task<ApiResultList<MedicineStockDto>> GetMedicineByStocks(Guid stockId)
        {
            return await _dMedicineStockService.GetMedicineByStocks(stockId);
        }
    }
}
