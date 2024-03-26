using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.Province;

namespace HIS.ApplicationService.Dictionaries.Provinces
{
    public interface IProvinceAppService : IAppService
    {
        Task<ResultDto<ProvinceDto>> CreateOrEdit(ProvinceDto input);
        Task<ResultDto<ProvinceDto>> Delete(Guid id);
        Task<PagedResultDto<ProvinceDto>> GetAll(GetAllProvinceInputDto input);
        Task<ResultDto<ProvinceDto>> GetById(Guid id);
    }
}
