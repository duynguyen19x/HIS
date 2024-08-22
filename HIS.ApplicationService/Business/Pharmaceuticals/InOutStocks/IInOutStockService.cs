using HIS.ApplicationService.Business.InOutStocks.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Business.Pharmaceuticals.InOutStocks
{
    public interface IInOutStockService : IAppService
    {
        Task<PagedResultDto<InOutStockDto>> GetByStocks(Guid stockId, DateTime fromDate, DateTime toDate);

        Task<ResultDto<InOutStockDto>> ImportFromSupplierGetById(Guid id);
        Task<ResultDto<InOutStockDto>> ImportFromSupplierCanceled(InOutStockDto input);
        Task<ResultDto<InOutStockDto>> ImportFromSupplierSaveAsDraft(InOutStockDto input);
        Task<ResultDto<InOutStockDto>> ImportFromSupplierStockIn(InOutStockDto input);
        Task<ResultDto<bool>> ImportFromSupplierDeleted(Guid id);

        Task<ResultDto<InOutStockDto>> ImportFromAnotherStockGetById(Guid id);
        Task<ResultDto<InOutStockDto>> ImportFromAnotherStockSaveAsDraft(InOutStockDto input);
        Task<ResultDto<InOutStockDto>> ImportFromAnotherStockRequest(InOutStockDto input);
        Task<ResultDto<InOutStockDto>> ImportFromAnotherStockCancelRequest(InOutStockDto input);
        Task<ResultDto<InOutStockDto>> ImportFromAnotherStockApproved(InOutStockDto input);
        Task<ResultDto<InOutStockDto>> ImportFromAnotherStockCancelApproved(InOutStockDto input);
        Task<ResultDto<InOutStockDto>> ImportFromAnotherStockStockOut(InOutStockDto input);
        Task<ResultDto<InOutStockDto>> ImportFromAnotherStockCanCelStockOut(InOutStockDto input);
        Task<ResultDto<InOutStockDto>> ImportFromAnotherStockStockIn(InOutStockDto input);
        Task<ResultDto<InOutStockDto>> ImportFromAnotherStockCancelStockIn(InOutStockDto input);
        Task<ResultDto<bool>> ImportFromAnotherStockDeleted(Guid id);

        Task<ResultDto<InOutStockDto>> ExportToSupplierGetById(Guid id);
        Task<ResultDto<InOutStockDto>> ExportToSupplierSaveAsDraft(InOutStockDto input);
        Task<ResultDto<InOutStockDto>> ExportToSupplierStockOut(InOutStockDto input);
        Task<ResultDto<InOutStockDto>> ExportToSupplierCanCelStockOut(InOutStockDto input);
        Task<ResultDto<bool>> ExportToSupplierDeleted(Guid id);
    }
}
