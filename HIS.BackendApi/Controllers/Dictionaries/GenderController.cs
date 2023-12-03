using HIS.Application.Core.Services.Dto;
using HIS.ApplicationService.Dictionaries.Gender;
using HIS.Dtos.Dictionaries.Gender;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : ControllerBase
    {
        private readonly IGenderService _genderService;

        public GenderController(IGenderService genderService)
        {
            _genderService = genderService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<GenderDto>> GetAll([FromQuery] GetAllGenderInput input)
        {
            return await _genderService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<GenderDto>> GetById(Guid id)
        {
            return await _genderService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<GenderDto>> CreateOrEdit(GenderDto input)
        {
            return await _genderService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<GenderDto>> Delete(Guid id)
        {
            return await _genderService.Delete(id);
        }
    }
}
