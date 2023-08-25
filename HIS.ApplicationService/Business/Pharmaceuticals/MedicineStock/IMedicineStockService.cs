using HIS.Dtos.Business.MedicineStock;
using HIS.Dtos.Commons;

namespace HIS.ApplicationService.Business.Pharmaceuticals.DMedicineStock
{
    public interface IMedicineStockService 
    {
        public Task<ApiResultList<MedicineStockDto>> GetAll(GetAllMedicineStockInput input);
        public Task<ApiResultList<MedicineStockDto>> GetMedicineByStocks(Guid stockId);
    }
}
