using HIS.ApplicationService.Dictionary.Districts.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.Districts
{
    public interface IDistrictAppService : IAppService
    {
        Task<ResultDto<DistrictDto>> CreateOrEdit(DistrictDto input);

        Task<ResultDto<DistrictDto>> Delete(Guid id);

        Task<PagedResultDto<DistrictDto>> GetAll(GetAllDistrictInputDto input);

        Task<ResultDto<DistrictDto>> GetById(Guid id);
    }
}
