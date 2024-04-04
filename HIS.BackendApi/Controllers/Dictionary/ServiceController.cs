using HIS.Dtos.Dictionaries.ServiceResultIndex;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Dictionary.Services.Dto;
using HIS.ApplicationService.Dictionary.Services;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceAppService _serviceService;

        public ServiceController(IServiceAppService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<ServiceDto>> CreateOrEdit(ServiceDto input)
        {
            return await _serviceService.CreateOrEdit(input);
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<ServiceDto>> GetAll([FromQuery] GetAllServiceInput input)
        {
            return await _serviceService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<ServiceDto>> GetById(Guid id)
        {
            return await _serviceService.GetById(id);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<ServiceDto>> Delete(Guid id)
        {
            return await _serviceService.Delete(id);
        }

        [HttpPost("Import")]
        public async Task<ResultDto<bool>> Import(IList<ServiceImportExcelDto> input)
        {
            return await _serviceService.Import(input);
        }

        [HttpPost("ImportServiceResultIndices")]
        public async Task<ResultDto<bool>> ImportServiceResultIndices(IList<ServiceResultIndiceDto> sServiceResultIndexs)
        {
            return await _serviceService.ImportServiceResultIndices(sServiceResultIndexs);
        }
    }
}
