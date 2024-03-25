using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.Countries;

namespace HIS.ApplicationService.Dictionaries.Countries
{
    public interface ICountryAppService : IAppService
    {
        Task<ResultDto<CountryDto>> CreateOrEdit(CountryDto input);
        Task<ResultDto<CountryDto>> Delete(Guid id);
        Task<PagedResultDto<CountryDto>> GetAll(GetAllCountryInputDto input);
        Task<ResultDto<CountryDto>> GetById(Guid id);
    }
}
