using HIS.ApplicationService.Dictionary.InvoiceGroups.Dto;
using HIS.ApplicationService.Dictionary.RelativeTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
