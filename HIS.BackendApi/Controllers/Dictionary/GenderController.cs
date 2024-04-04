using HIS.ApplicationService.Dictionary.Genders;
using HIS.ApplicationService.Dictionary.Genders.Dto;
using HIS.ApplicationService.Dictionary.Hospitals.Dto;
using HIS.Core.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : ControllerBase
    {
        private readonly IGenderAppService _genderAppService;

        public GenderController(IGenderAppService genderAppService)
        {
            _genderAppService = genderAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<GenderDto>> GetAll([FromQuery] GetAllGenderInputDto input)
        {
            return await _genderAppService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<GenderDto>> GetById(Guid id)
        {
            return await _genderAppService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<GenderDto>> CreateOrEdit(GenderDto input)
        {
            return await _genderAppService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<GenderDto>> Delete(Guid id)
        {
            return await _genderAppService.Delete(id);
        }
    }
}
