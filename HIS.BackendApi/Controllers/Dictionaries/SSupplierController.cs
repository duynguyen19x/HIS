using HIS.ApplicationService.Dictionaries.Branch;
using HIS.ApplicationService.Dictionaries.Supplier;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Branch;
using HIS.Dtos.Dictionaries.Supplier;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SSupplierController : ControllerBase
    {
        private readonly ISSupplierService _sSupplierService;

        public SSupplierController(ISSupplierService sSupplierService)
        {
            _sSupplierService = sSupplierService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SSupplierDto>> GetAll([FromQuery] GetAllSSupplierInput input)
        {
            return await _sSupplierService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SSupplierDto>> GetById(Guid id)
        {
            return await _sSupplierService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SSupplierDto>> CreateOrEdit(SSupplierDto input)
        {
            return await _sSupplierService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<SSupplierDto>> Delete(Guid id)
        {
            return await _sSupplierService.Delete(id);
        }
    }
}
