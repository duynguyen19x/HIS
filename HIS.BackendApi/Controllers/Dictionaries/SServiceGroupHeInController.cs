using HIS.ApplicationService.Dictionaries.ServiceGroup;
using HIS.ApplicationService.Dictionaries.ServiceGroupHeIn;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ServiceGroup;
using HIS.Dtos.Dictionaries.ServiceGroupHeIn;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SServiceGroupHeInController : ControllerBase
    {
        private readonly IServiceGroupHeInService _serviceGroupHeImService;

        public SServiceGroupHeInController(IServiceGroupHeInService serviceGroupHeImService)
        {
            _serviceGroupHeImService = serviceGroupHeImService;
        }

        [HttpGet("CreateOrEdit")]
        public async Task<ApiResult<SServiceGroupHeInDto>> CreateOrEdit(SServiceGroupHeInDto input)
        {
            return await _serviceGroupHeImService.CreateOrEdit(input);
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SServiceGroupHeInDto>> GetAll([FromQuery] GetAllSServiceGroupHeInInput input)
        {
            return await _serviceGroupHeImService.GetAll(input);
        }

        [HttpDelete("GetById")]
        public async Task<ApiResult<SServiceGroupHeInDto>> GetById(Guid id)
        {
            return await _serviceGroupHeImService.GetById(id);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<SServiceGroupHeInDto>> Delete(Guid id)
        {
            return await _serviceGroupHeImService.Delete(id);
        }
    }
}
