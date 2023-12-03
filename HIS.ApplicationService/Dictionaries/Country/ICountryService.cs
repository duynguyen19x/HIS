using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.Country;

namespace HIS.ApplicationService.Dictionaries.Country
{
    public interface ICountryService : IBaseCrudAppService<CountryDto, Guid?, GetAllCountryInput>
    {
    }
}
