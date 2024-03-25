using HIS.ApplicationService.Dictionary.Suppliers.Dto;
using HIS.ApplicationService.Dictionary.Units.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.Suppliers
{
    public interface ISupplierAppService : IAppService
    {
        Task<ResultDto<SupplierDto>> CreateOrEdit(SupplierDto input);
        Task<ResultDto<SupplierDto>> Delete(Guid id);
        Task<PagedResultDto<SupplierDto>> GetAll(GetAllSupplierInput input);
        Task<ResultDto<SupplierDto>> GetById(Guid id);
    }
}
