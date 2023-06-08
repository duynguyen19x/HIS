using HIS.ApplicationService.Dictionaries.Service;
using HIS.ApplicationService.Dictionaries.ServicePricePolicy;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Service;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public SServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet("CreateOrEdit")]
        public async Task<ApiResult<SServiceDto>> CreateOrEdit(SServiceDto input)
        {
            return await _serviceService.CreateOrEdit(input);
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SServiceDto>> GetAll([FromQuery] GetAllSServiceInput input)
        {
            return await _serviceService.GetAll(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<SServiceDto>> Delete(Guid id)
        {
            return await _serviceService.Delete(id);
        }
    }
}
