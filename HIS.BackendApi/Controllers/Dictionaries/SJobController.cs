using HIS.ApplicationService.Dictionaries.Branch;
using HIS.ApplicationService.Dictionaries.Job;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Branch;
using HIS.Dtos.Dictionaries.Job;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SJobController : ControllerBase
    {
        private readonly ISJobService _jobService;

        public SJobController(ISJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SJobDto>> GetAll([FromQuery] GetAllSJobInput input)
        {
            return await _jobService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SJobDto>> GetById(Guid id)
        {
            return await _jobService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SJobDto>> CreateOrEdit(SJobDto input)
        {
            return await _jobService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<SJobDto>> Delete(Guid id)
        {
            return await _jobService.Delete(id);
        }
    }
}
