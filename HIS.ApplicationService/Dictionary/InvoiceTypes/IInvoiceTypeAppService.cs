using HIS.ApplicationService.Dictionary.InvoiceTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.InvoiceTypes
{
    public interface IInvoiceTypeAppService : IAppService
    {
        Task<PagedResultDto<InvoiceTypeDto>> GetAll(GetAllInvoiceTypeInputDto input);
    }
}
