using HIS.Dtos.Business.InOutStock;
using HIS.Dtos.Commons;
using HIS.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Pharmaceuticals.InOutStock
{
    public interface IInOutStockService
    {
        Task<ApiResultList<InOutStockDto>> GetByStocks(Guid stockId, string fromDate, string toDate);

        Task<ApiResult<InOutStockDto>> ImportFromSupplierGetById(Guid id);
        Task<ApiResult<InOutStockDto>> ImportFromSupplierCanceled(InOutStockDto input);
        Task<ApiResult<InOutStockDto>> ImportFromSupplierSaveAsDraft(InOutStockDto input);
        Task<ApiResult<InOutStockDto>> ImportFromSupplierStockIn(InOutStockDto input);
        Task<ApiResult<bool>> ImportFromSupplierDeleted(Guid id);

        Task<ApiResult<InOutStockDto>> ImportFromAnotherStockGetById(Guid id);
        Task<ApiResult<InOutStockDto>> ImportFromAnotherStockSaveAsDraft(InOutStockDto input);
        Task<ApiResult<InOutStockDto>> ImportFromAnotherStockRequest(InOutStockDto input);
        Task<ApiResult<InOutStockDto>> ImportFromAnotherStockCancelRequest(InOutStockDto input);
        Task<ApiResult<InOutStockDto>> ImportFromAnotherStockApproved(InOutStockDto input);
        Task<ApiResult<InOutStockDto>> ImportFromAnotherStockCancelApproved(InOutStockDto input);
        Task<ApiResult<InOutStockDto>> ImportFromAnotherStockStockOut(InOutStockDto input);
        Task<ApiResult<InOutStockDto>> ImportFromAnotherStockCanCelStockOut(InOutStockDto input);
        Task<ApiResult<InOutStockDto>> ImportFromAnotherStockStockIn(InOutStockDto input);
        Task<ApiResult<InOutStockDto>> ImportFromAnotherStockCancelStockIn(InOutStockDto input);
        Task<ApiResult<bool>> ImportFromAnotherStockDeleted(Guid id);
    }
}
