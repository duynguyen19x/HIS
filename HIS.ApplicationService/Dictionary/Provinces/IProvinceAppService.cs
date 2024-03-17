using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.Province;

namespace HIS.ApplicationService.Dictionaries.Provinces
{
    public interface IProvinceAppService : IBaseCrudAppService<ProvinceDto, Guid?, GetAllProvinceInput>
    {
    }
}
