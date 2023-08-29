using HIS.ApplicationService.Dictionaries.ServiceGroupHeIn;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ServiceGroupHeIn;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ApiResult<ServiceGroupHeInDto>> CreateOrEdit(ServiceGroupHeInDto input)
        {
            return await _serviceGroupHeImService.CreateOrEdit(input);
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<ServiceGroupHeInDto>> GetAll([FromQuery] GetAllServiceGroupHeInInput input)
        {
            return await _serviceGroupHeImService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<ServiceGroupHeInDto>> GetById(Guid id)
        {
            return await _serviceGroupHeImService.GetById(id);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<ServiceGroupHeInDto>> Delete(Guid id)
        {
            return await _serviceGroupHeImService.Delete(id);
        }
    }
}
