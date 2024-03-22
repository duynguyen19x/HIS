using HIS.ApplicationService.System.Permissions.Dto;
using HIS.ApplicationService.Systems.Roles.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.System.Roles
{
    public interface IRoleAppService : IAppService
    {
        Task<PagedResultDto<RoleDto>> GetAllAsync(GetAllRoleInputDto input);

        Task<ResultDto<RoleDto>> GetAsync(Guid id);

        Task<ResultDto<RoleDto>> CreateOrUpdateAsync(RoleDto input);

        Task<ResultDto<RoleDto>> DeleteAsync(Guid id);

    }
}
