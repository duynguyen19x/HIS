using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Systems.Role;

namespace HIS.ApplicationService.Systems.Role
{
    public interface IRoleService
    {
        Task<PagedResultDto<RoleDto>> GetAll(GetAllRoleInput input);
        Task<ResultDto<RoleDto>> GetById(Guid id);
        Task<ResultDto<RoleDto>> CreateOrEdit(RoleDto input);
        Task<ResultDto<RoleDto>> Delete(Guid id);
    }
}
