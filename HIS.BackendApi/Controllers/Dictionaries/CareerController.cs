using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Dictionary.Careers;
using HIS.ApplicationService.Dictionary.Careers.Dto;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class CareerController : ControllerBase
    {
        private readonly ICareerAppService _careerService;

        public CareerController(ICareerAppService careerService)
        {
            _careerService = careerService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<CareerDto>> GetAll([FromQuery] GetAllCareerInput input)
        {
            return await _careerService.GetAllAsync(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<CareerDto>> GetById(Guid id)
        {
            return await _careerService.GetAsync(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<CareerDto>> CreateOrEdit(CareerDto input)
        {
            return await _careerService.CreateOrUpdateAsync(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<CareerDto>> Delete(Guid id)
        {
            return await _careerService.DeleteAsync(id);
        }
    }
}
