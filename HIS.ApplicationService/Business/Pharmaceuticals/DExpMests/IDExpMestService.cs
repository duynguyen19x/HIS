using HIS.Dtos.Business.InOutStock;
using HIS.Dtos.Commons;
using HIS.Models.Commons;

namespace HIS.ApplicationService.Business.Pharmaceuticals.DExpMests
{
    public interface IDExpMestService
    {
        public Task<ApiResultList<InOutStockDto>> GetByStocks(Guid stockId, string fromDate, string toDate);

        public Task<ApiResult<InOutStockDto>> ExpFromAnotherStockGetById(Guid id);
    }
}
