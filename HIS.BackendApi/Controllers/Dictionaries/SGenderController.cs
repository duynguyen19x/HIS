using HIS.ApplicationService.Dictionaries.Career;
using HIS.ApplicationService.Dictionaries.Gender;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Career;
using HIS.Dtos.Dictionaries.Gender;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SGenderController : ControllerBase
    {
        private readonly ISGenderService _genderService;

        public SGenderController(ISGenderService genderService)
        {
            _genderService = genderService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SGenderDto>> GetAll([FromQuery] GetAllSGenderInput input)
        {
            return await _genderService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SGenderDto>> GetById(Guid id)
        {
            return await _genderService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SGenderDto>> CreateOrEdit(SGenderDto input)
        {
            return await _genderService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<SGenderDto>> Delete(Guid id)
        {
            return await _genderService.Delete(id);
        }
    }
}
