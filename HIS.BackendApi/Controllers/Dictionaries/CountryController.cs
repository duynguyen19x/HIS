using HIS.ApplicationService.Dictionaries.Country;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Country;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<CountryDto>> GetAll([FromQuery] GetAllCountryInput input)
        {
            return await _countryService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<CountryDto>> GetById(Guid id)
        {
            return await _countryService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<CountryDto>> CreateOrEdit(CountryDto input)
        {
            return await _countryService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<CountryDto>> Delete(Guid id)
        {
            return await _countryService.Delete(id);
        }
    }
}
