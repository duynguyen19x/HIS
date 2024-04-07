using HIS.ApplicationService.Dictionary.RightRouteTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionaries.RightRouteTypes
{
    public interface IRightRouteTypeAppService : IAppService
    {
        Task<PagedResultDto<RightRouteTypeDto>> GetAll(GetAllRightRouteTypeInputDto input);
    }
}
