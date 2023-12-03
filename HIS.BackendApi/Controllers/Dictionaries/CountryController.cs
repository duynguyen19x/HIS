using HIS.Application.Core.Services.Dto;
using HIS.ApplicationService.Dictionaries.Country;
using HIS.Dtos.Dictionaries.Country;
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
        public async Task<PagedResultDto<CountryDto>> GetAll([FromQuery] GetAllCountryInput input)
        {
            return await _countryService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<CountryDto>> GetById(Guid id)
        {
            return await _countryService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<CountryDto>> CreateOrEdit(CountryDto input)
        {
            return await _countryService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<CountryDto>> Delete(Guid id)
        {
            return await _countryService.Delete(id);
        }
    }
}
