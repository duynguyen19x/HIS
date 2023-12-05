using HIS.Application.Core.Services.Dto;
using HIS.ApplicationService.Dictionaries.Career;
using HIS.Dtos.Dictionaries.Career;
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
        public async Task<PagedResultDto<CareerDto>> GetAll([FromQuery] GetAllCareerInput input)
        {
            return await _jobService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<CareerDto>> GetById(Guid id)
        {
            return await _jobService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<CareerDto>> CreateOrEdit(CareerDto input)
        {
            return await _jobService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<CareerDto>> Delete(Guid id)
        {
            return await _jobService.Delete(id);
        }
    }
}
