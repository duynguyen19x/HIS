using HIS.Core.Services.Dto;
using HIS.ApplicationService.Dictionaries.Service;
using HIS.Dtos.Dictionaries.Service;
using HIS.Dtos.Dictionaries.ServiceResultIndex;
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
