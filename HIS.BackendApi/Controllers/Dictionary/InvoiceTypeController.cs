using HIS.ApplicationService.Business.Invoices;
using HIS.ApplicationService.Dictionary.InvoiceTypes;
using HIS.ApplicationService.Dictionary.InvoiceTypes.Dto;
using HIS.ApplicationService.Dictionary.Services.Dto;
using HIS.Core.Application.Services.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionary
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceTypeController : ControllerBase
    {
        private readonly IInvoiceTypeAppService _invoiceTypeAppService;

        public InvoiceTypeController(IInvoiceTypeAppService invoiceTypeAppService) 
        {
            _invoiceTypeAppService = invoiceTypeAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<InvoiceTypeDto>> GetAll([FromQuery] GetAllInvoiceTypeInputDto input)
        {
            return await _invoiceTypeAppService.GetAll(input);
        }
    }
}
