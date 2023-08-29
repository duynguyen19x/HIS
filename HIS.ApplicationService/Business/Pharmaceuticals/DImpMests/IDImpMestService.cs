using HIS.Dtos.Business.InOutStock;
using HIS.Dtos.Commons;
using HIS.Models.Commons;

namespace HIS.ApplicationService.Business.Pharmaceuticals.DImpMests
{
    public interface IDImpMestService
    {
        public Task<ApiResultList<InOutStockDto>> GetByStocks(Guid stockId, string fromDate, string toDate);

        public Task<ApiResult<InOutStockDto>> ImportFromSupplierSaveAsDraft(InOutStockDto input);
        public Task<ApiResult<InOutStockDto>> ImportFromSupplierStockIn(InOutStockDto input);
        public Task<ApiResult<bool>> ImportFromSupplierCanceled(Guid id);
        public Task<ApiResult<InOutStockDto>> ImportFromSupplierGetById(Guid id);

        public Task<ApiResult<InOutStockDto>> ImportFromAnotherStockGetById(Guid id);
        public Task<ApiResult<InOutStockDto>> ImportFromAnotherStockSaveAsDraft(InOutStockDto input);
        public Task<ApiResult<InOutStockDto>> ImportFromAnotherStockRequest(InOutStockDto input);
        public Task<ApiResult<InOutStockDto>> ImportFromAnotherStockStockIn(InOutStockDto input);
    }
}
