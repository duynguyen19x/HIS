using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Dictionary.Suppliers.Dto;
using HIS.ApplicationService.Dictionary.Suppliers;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierAppService _sSupplierService;

        public SupplierController(ISupplierAppService sSupplierService)
        {
            _sSupplierService = sSupplierService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<SupplierDto>> GetAll([FromQuery] GetAllSupplierInput input)
        {
            return await _sSupplierService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<SupplierDto>> GetById(Guid id)
        {
            return await _sSupplierService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<SupplierDto>> CreateOrEdit(SupplierDto input)
        {
            return await _sSupplierService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<SupplierDto>> Delete(Guid id)
        {
            return await _sSupplierService.Delete(id);
        }
    }
}
