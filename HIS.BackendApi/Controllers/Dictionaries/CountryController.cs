using HIS.Application.Core.Services.Dto;
using HIS.ApplicationService.Dictionaries.Countries;
using HIS.Dtos.Dictionaries.Countries;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : BaseCrudController<ICountryAppService, CountryDto, Guid?, GetAllCountryInputDto>
    {
        public CountryController(ICountryAppService countryAppService)
            : base(countryAppService)
        {
        }
    }
}
