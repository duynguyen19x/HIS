using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.Nationals;

namespace HIS.ApplicationService.Dictionaries.Country
{
    public interface ICountryService : IBaseCrudAppService<NationalDto, Guid?, GetAllNationalInputDto>
    {
    }
}
