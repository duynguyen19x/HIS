using HIS.ApplicationService.Dictionaries.Country;
using HIS.ApplicationService.Dictionaries.Career;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Country;
using HIS.Dtos.Dictionaries.Career;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SCountryController : ControllerBase
    {
        private readonly ISCountryService _countryService;

        public SCountryController(ISCountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SCountryDto>> GetAll([FromQuery] GetAllSCountryInput input)
        {
            return await _countryService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SCountryDto>> GetById(Guid id)
        {
            return await _countryService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SCountryDto>> CreateOrEdit(SCountryDto input)
        {
            return await _countryService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<SCountryDto>> Delete(Guid id)
        {
            return await _countryService.Delete(id);
        }
    }
}
