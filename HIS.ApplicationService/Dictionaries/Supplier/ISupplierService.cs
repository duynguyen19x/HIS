using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.Supplier;

namespace HIS.ApplicationService.Dictionaries.Supplier
{
    public interface ISupplierService : IBaseCrudAppService<SupplierDto, Guid?, GetAllSupplierInput>
    {

    }
}
