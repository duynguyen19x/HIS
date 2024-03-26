using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.RightRouteTypes;

namespace HIS.ApplicationService.Dictionaries.RightRouteTypes
{
    public interface IRightRouteTypeAppService : IAppService
    {
        Task<ResultDto<RightRouteTypeDto>> CreateOrEdit(RightRouteTypeDto input);
        Task<ResultDto<RightRouteTypeDto>> Delete(int id);
        Task<PagedResultDto<RightRouteTypeDto>> GetAll(GetAllRightRouteTypeInputDto input);
        Task<ResultDto<RightRouteTypeDto>> GetById(int id);
    }
}
