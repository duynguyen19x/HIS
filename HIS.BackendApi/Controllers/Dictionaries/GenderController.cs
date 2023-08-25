using HIS.ApplicationService.Dictionaries.Gender;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Gender;
using HIS.Models.Commons;
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
        public async Task<ApiResultList<GenderDto>> GetAll([FromQuery] GetAllGenderInput input)
        {
            return await _genderService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<GenderDto>> GetById(Guid id)
        {
            return await _genderService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<GenderDto>> CreateOrEdit(GenderDto input)
        {
            return await _genderService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<GenderDto>> Delete(Guid id)
        {
            return await _genderService.Delete(id);
        }
    }
}
