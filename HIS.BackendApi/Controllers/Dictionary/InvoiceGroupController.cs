using HIS.ApplicationService.Dictionary.Genders.Dto;
using HIS.ApplicationService.Dictionary.InvoiceGroups;
using HIS.ApplicationService.Dictionary.InvoiceGroups.Dto;
using HIS.Core.Application.Services.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionary
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceGroupController : ControllerBase
    {
        private readonly IInvoiceGroupAppService _invoiceGroupAppService;

        public InvoiceGroupController(IInvoiceGroupAppService invoiceGroupAppService)
        {
            _invoiceGroupAppService = invoiceGroupAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<InvoiceGroupDto>> GetAll([FromQuery] GetAllInvoiceGroupInputDto input)
        {
            return await _invoiceGroupAppService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<InvoiceGroupDto>> GetById(Guid id)
        {
            return await _invoiceGroupAppService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<InvoiceGroupDto>> CreateOrEdit(InvoiceGroupDto input)
        {
            return await _invoiceGroupAppService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<InvoiceGroupDto>> Delete(Guid id)
        {
            return await _invoiceGroupAppService.Delete(id);
        }
    }
}
