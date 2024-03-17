using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.Countries;

namespace HIS.ApplicationService.Dictionaries.Countries
{
    public interface ICountryAppService : IBaseCrudAppService<CountryDto, Guid?, GetAllCountryInputDto>
    {
    }
}
