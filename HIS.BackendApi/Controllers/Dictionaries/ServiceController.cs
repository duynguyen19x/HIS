using HIS.ApplicationService.Dictionaries.Service;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Service;
using HIS.Dtos.Dictionaries.ServiceResultIndex;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<ServiceDto>> CreateOrEdit(ServiceDto input)
        {
            return await _serviceService.CreateOrEdit(input);
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<ServiceDto>> GetAll([FromQuery] GetAllServiceInput input)
        {
            return await _serviceService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<ServiceDto>> GetById(Guid id)
        {
            return await _serviceService.GetById(id);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<ServiceDto>> Delete(Guid id)
        {
            return await _serviceService.Delete(id);
        }

        [HttpPost("Import")]
        public async Task<ApiResult<bool>> Import(IList<ServiceImportExcelDto> input)
        {
            return await _serviceService.Import(input);
        }

        [HttpPost("ImportServiceResultIndices")]
        public async Task<ApiResult<bool>> ImportServiceResultIndices(IList<ServiceResultIndiceDto> sServiceResultIndexs)
        {
            return await _serviceService.ImportServiceResultIndices(sServiceResultIndexs);
        }
    }
}
