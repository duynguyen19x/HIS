using HIS.ApplicationService.Dictionaries.ServiceGroup;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ServiceGroup;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SServiceGroupController : ControllerBase
    {
        private readonly IServiceGroupService _serviceGroupService;

        public SServiceGroupController(IServiceGroupService serviceGroupService)
        {
            _serviceGroupService = serviceGroupService;
        }

        [HttpGet("CreateOrEdit")]
        public async Task<ApiResult<SServiceGroupDto>> CreateOrEdit(SServiceGroupDto input)
        {
            return await _serviceGroupService.CreateOrEdit(input);
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SServiceGroupDto>> GetAll([FromQuery] GetAllSServiceGroupInput input)
        {
            return await _serviceGroupService.GetAll(input);
        }

        [HttpDelete("GetById")]
        public async Task<ApiResult<SServiceGroupDto>> GetById(Guid id)
        {
            return await _serviceGroupService.GetById(id);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<SServiceGroupDto>> Delete(Guid id)
        {
            return await _serviceGroupService.Delete(id);
        }
    }
}
