using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.InOutStocks;

namespace HIS.ApplicationService.Business.Pharmaceuticals.InOutStocks
{
    public interface IInOutStockService
    {
        Task<PagedResultDto<InOutStockDto>> GetByStocks(Guid stockId, string fromDate, string toDate);

        Task<ResultDto<InOutStockDto>> ImportFromSupplierGetById(Guid id);
        Task<ResultDto<InOutStockDto>> ImportFromSupplierCanceled(InOutStockDto input);
        Task<ResultDto<InOutStockDto>> ImportFromSupplierSaveAsDraft(InOutStockDto input);
        Task<ResultDto<InOutStockDto>> ImportFromSupplierStockIn(InOutStockDto input);
        Task<ResultDto<bool>> ImportFromSupplierDeleted(Guid id);

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

        Task<ApiResult<InOutStockDto>> ExportToSupplierGetById(Guid id);
        Task<ApiResult<InOutStockDto>> ExportToSupplierSaveAsDraft(InOutStockDto input);
        Task<ApiResult<InOutStockDto>> ExportToSupplierStockOut(InOutStockDto input);
        Task<ApiResult<InOutStockDto>> ExportToSupplierCanCelStockOut(InOutStockDto input);
        Task<ApiResult<bool>> ExportToSupplierDeleted(Guid id);
    }
}
