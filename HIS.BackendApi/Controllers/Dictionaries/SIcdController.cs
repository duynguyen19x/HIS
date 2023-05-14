using HIS.ApplicationService.Dictionaries.Icd;
using HIS.ApplicationService.Dictionaries.Career;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Icd;
using HIS.Dtos.Dictionaries.Career;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SIcdController : ControllerBase
    {
        private readonly ISIcdService _icdService;

        public SIcdController(ISIcdService icdService)
        {
            _icdService = icdService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SIcdDto>> GetAll([FromQuery] GetAllSIcdInput input)
        {
            return await _icdService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SIcdDto>> GetById(Guid id)
        {
            return await _icdService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SIcdDto>> CreateOrEdit(SIcdDto input)
        {
            return await _icdService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<SIcdDto>> Delete(Guid id)
        {
            return await _icdService.Delete(id);
        }
    }
}
