using HIS.ApplicationService.Dictionaries.Career;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Career;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class CareerController : ControllerBase
    {
        private readonly ICareerService _jobService;

        public CareerController(ICareerService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<CareerDto>> GetAll([FromQuery] GetAllCareerInput input)
        {
            return await _jobService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<CareerDto>> GetById(Guid id)
        {
            return await _jobService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<CareerDto>> CreateOrEdit(CareerDto input)
        {
            return await _jobService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<CareerDto>> Delete(Guid id)
        {
            return await _jobService.Delete(id);
        }
    }
}
