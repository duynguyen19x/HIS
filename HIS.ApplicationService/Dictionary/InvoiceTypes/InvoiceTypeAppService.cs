using HIS.ApplicationService.Dictionary.InvoiceTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.InvoiceTypes
{
    public class InvoiceTypeAppService : BaseAppService, IInvoiceTypeAppService
    {
        private readonly IRepository<InvoiceType, int> _invoiceTypeRepository;

        public InvoiceTypeAppService(IRepository<InvoiceType, int> invoiceTypeRepository) 
        {
            _invoiceTypeRepository = invoiceTypeRepository;
        }

        public virtual async Task<PagedResultDto<InvoiceTypeDto>> GetAll(GetAllInvoiceTypeInputDto input)
        {
            var result = new PagedResultDto<InvoiceTypeDto>();
            try
            {
                var filter = _invoiceTypeRepository.GetAll()
                    .OrderBy(o => o.SortOrder);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<InvoiceTypeDto>>(filter.ToList());
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }
    }
}
