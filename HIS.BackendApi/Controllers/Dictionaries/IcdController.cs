using HIS.ApplicationService.Dictionaries.Icd;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Icd;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class IcdController : ControllerBase
    {
        private readonly IIcdService _icdService;

        public IcdController(IIcdService icdService)
        {
            _icdService = icdService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<IcdDto>> GetAll([FromQuery] GetAllIcdInput input)
        {
            return await _icdService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<IcdDto>> GetById(Guid id)
        {
            return await _icdService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<IcdDto>> CreateOrEdit(IcdDto input)
        {
            return await _icdService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<IcdDto>> Delete(Guid id)
        {
            return await _icdService.Delete(id);
        }
    }
}
