using HIS.Core.Services.Dto;
using HIS.ApplicationService.Dictionaries.ServiceGroup;
using HIS.Dtos.Dictionaries.ServiceGroup;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceGroupController : ControllerBase
    {
        private readonly IServiceGroupService _serviceGroupService;

        public ServiceGroupController(IServiceGroupService serviceGroupService)
        {
            _serviceGroupService = serviceGroupService;
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<ServiceGroupDto>> CreateOrEdit(ServiceGroupDto input)
        {
            return await _serviceGroupService.CreateOrEdit(input);
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<ServiceGroupDto>> GetAll([FromQuery] GetAllServiceGroupInput input)
        {
            return await _serviceGroupService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<ServiceGroupDto>> GetById(Guid id)
        {
            return await _serviceGroupService.GetById(id);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<ServiceGroupDto>> Delete(Guid id)
        {
            return await _serviceGroupService.Delete(id);
        }
    }
}
