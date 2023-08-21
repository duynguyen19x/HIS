using HIS.Dtos.Business.DImpMest;
using HIS.Dtos.Business.DMedicineStock;
using HIS.Dtos.Commons;
using HIS.Models.Commons;

namespace HIS.ApplicationService.Business.Pharmaceuticals.DImpMests
{
    public interface IDImpMestService
    {
        public Task<ApiResultList<DImpMestDto>> GetByStocks(Guid stockId, string fromDate, string toDate);
        public Task<ApiResultList<DMedicineStockDto>> GetMedicineByStocks(Guid stockId);

        public Task<ApiResult<DImpMestDto>> ImportFromSupplierSaveAsDraft(DImpMestDto input);
        public Task<ApiResult<DImpMestDto>> ImportFromSupplierStockIn(DImpMestDto input);
        public Task<ApiResult<bool>> ImportFromSupplierCanceled(Guid id);
        public Task<ApiResult<DImpMestDto>> ImportFromSupplierGetById(Guid id);

        public Task<ApiResult<DImpMestDto>> ImportFromAnotherStockGetById(Guid id);
        public Task<ApiResult<DImpMestDto>> ImportFromAnotherStockSaveAsDraft(DImpMestDto input);
        public Task<ApiResult<DImpMestDto>> ImportFromAnotherStockRequest(DImpMestDto input);
        public Task<ApiResult<DImpMestDto>> ImportFromAnotherStockStockIn(DImpMestDto input);
    }
}
