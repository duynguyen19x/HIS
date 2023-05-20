using HIS.ApplicationService.Dictionaries.Branch;
using HIS.ApplicationService.Dictionaries.Career;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Branch;
using HIS.Dtos.Dictionaries.Career;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SCareerController : ControllerBase
    {
        private readonly ISCareerService _jobService;

        public SCareerController(ISCareerService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SCareerDto>> GetAll([FromQuery] GetAllSCareerInput input)
        {
            return await _jobService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SCareerDto>> GetById(Guid id)
        {
            return await _jobService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SCareerDto>> CreateOrEdit(SCareerDto input)
        {
            return await _jobService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<SCareerDto>> Delete(Guid id)
        {
            return await _jobService.Delete(id);
        }
    }
}
