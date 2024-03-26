using HIS.ApplicationService.Dictionaries.Countries;
using HIS.ApplicationService.Dictionary.Genders;
using HIS.ApplicationService.Dictionary.Genders.Dto;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.Countries;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryAppService _countryAppService;

        public CountryController(ICountryAppService countryAppService)
        {
            _countryAppService = countryAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<CountryDto>> GetAll([FromQuery] GetAllCountryInputDto input)
        {
            return await _countryAppService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<CountryDto>> GetById(Guid id)
        {
            return await _countryAppService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<CountryDto>> CreateOrEdit(CountryDto input)
        {
            return await _countryAppService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<CountryDto>> Delete(Guid id)
        {
            return await _countryAppService.Delete(id);
        }
    }
}
