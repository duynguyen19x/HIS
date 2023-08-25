using HIS.ApplicationService.Dictionaries.ServiceGroup;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ServiceGroup;
using HIS.Models.Commons;
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
        public async Task<ApiResult<ServiceGroupDto>> CreateOrEdit(ServiceGroupDto input)
        {
            return await _serviceGroupService.CreateOrEdit(input);
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<ServiceGroupDto>> GetAll([FromQuery] GetAllServiceGroupInput input)
        {
            return await _serviceGroupService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<ServiceGroupDto>> GetById(Guid id)
        {
            return await _serviceGroupService.GetById(id);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<ServiceGroupDto>> Delete(Guid id)
        {
            return await _serviceGroupService.Delete(id);
        }
    }
}
