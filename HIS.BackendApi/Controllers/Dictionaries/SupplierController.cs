using HIS.Application.Core.Services.Dto;
using HIS.ApplicationService.Dictionaries.Supplier;
using HIS.Dtos.Dictionaries.Supplier;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _sSupplierService;

        public SupplierController(ISupplierService sSupplierService)
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
