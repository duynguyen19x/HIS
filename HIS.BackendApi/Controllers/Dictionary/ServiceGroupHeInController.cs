using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Dictionary.ServiceGroupHeIns.Dto;
using HIS.ApplicationService.Dictionary.ServiceGroupHeIns;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceGroupHeInController : ControllerBase
    {
        private readonly IServiceGroupHeInService _serviceGroupHeImService;

        public ServiceGroupHeInController(IServiceGroupHeInService serviceGroupHeImService)
        {
            _serviceGroupHeImService = serviceGroupHeImService;
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<ServiceGroupHeInDto>> CreateOrEdit(ServiceGroupHeInDto input)
        {
            return await _serviceGroupHeImService.CreateOrEdit(input);
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<ServiceGroupHeInDto>> GetAll([FromQuery] GetAllServiceGroupHeInInput input)
        {
            return await _serviceGroupHeImService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<ServiceGroupHeInDto>> GetById(Guid id)
        {
            return await _serviceGroupHeImService.GetById(id);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<ServiceGroupHeInDto>> Delete(Guid id)
        {
            return await _serviceGroupHeImService.Delete(id);
        }
    }
}
