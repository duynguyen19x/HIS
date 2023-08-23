using HIS.Dtos.Business.DMedicineStock;
using HIS.Dtos.Commons;

namespace HIS.ApplicationService.Business.Pharmaceuticals.DMedicineStock
{
    public interface IDMedicineStockService 
    {
        public Task<ApiResultList<DMedicineStockDto>> GetAll(GetAllDMedicineStockInput input);
        public Task<ApiResultList<DMedicineStockDto>> GetMedicineByStocks(Guid stockId);
    }
}
