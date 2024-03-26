using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Dictionary.Icds;
using HIS.ApplicationService.Dictionary.Icds.Dto;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class IcdController : ControllerBase
    {
        private readonly IIcdAppService _icdService;

        public IcdController(IIcdAppService icdService)
        {
            _icdService = icdService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<IcdDto>> GetAll([FromQuery] GetAllIcdInput input)
        {
            return await _icdService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<IcdDto>> GetById(Guid id)
        {
            return await _icdService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<IcdDto>> CreateOrEdit(IcdDto input)
        {
            return await _icdService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<IcdDto>> Delete(Guid id)
        {
            return await _icdService.Delete(id);
        }
    }
}
