using HIS.Dtos.Business.DImpMest;
using HIS.Dtos.Commons;
using HIS.Models.Commons;

namespace HIS.ApplicationService.Business.Pharmaceuticals.DImpMests
{
    public interface IDImpMestService
    {
        public Task<ApiResultList<DImpMestDto>> GetByStock(Guid stockId, string fromDate, string toDate);

        public Task<ApiResult<DImpMestDto>> ImportFromSupplierSaveAsDraft(DImpMestDto input);
        public Task<ApiResult<DImpMestDto>> ImportFromSupplierStockIn(DImpMestDto input);
        public Task<ApiResult<bool>> ImportFromSupplierCanceled(Guid id);
        public Task<ApiResult<DImpMestDto>> ImportFromSupplierGetById(Guid id);
        Task<ApiResult<DImpMestDto>> GetById(Guid id);
    }
}
