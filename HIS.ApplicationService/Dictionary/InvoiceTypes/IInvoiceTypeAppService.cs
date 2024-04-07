using HIS.ApplicationService.Dictionary.InvoiceTypes.Dto;
using HIS.ApplicationService.Dictionary.RelativeTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.InvoiceTypes
{
    public interface IInvoiceTypeAppService : IAppService
    {
        Task<PagedResultDto<InvoiceTypeDto>> GetAll(GetAllInvoiceTypeInputDto input);
    }
}
