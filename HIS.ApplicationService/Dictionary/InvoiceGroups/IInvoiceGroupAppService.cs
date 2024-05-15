using HIS.ApplicationService.Dictionary.InvoiceGroups.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.InvoiceGroups
{
    public interface IInvoiceGroupAppService : IAppService
    {
        Task<ResultDto<InvoiceGroupDto>> CreateOrEdit(InvoiceGroupDto input);

        Task<ResultDto<InvoiceGroupDto>> Delete(Guid id);

        Task<PagedResultDto<InvoiceGroupDto>> GetAll(GetAllInvoiceGroupInputDto input);

        Task<ResultDto<InvoiceGroupDto>> GetById(Guid id);
    }
}
