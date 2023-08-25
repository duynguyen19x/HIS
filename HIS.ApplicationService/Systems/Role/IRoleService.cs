using HIS.Dtos.Commons;
using HIS.Dtos.Systems.Login;
using HIS.Dtos.Systems.Role;
using HIS.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.Role
{
    public interface IRoleService
    {
        Task<ApiResultList<RoleDto>> GetAll(GetAllRoleInput input);
        Task<ApiResult<RoleDto>> GetById(Guid id);
        Task<ApiResult<RoleDto>> CreateOrEdit(RoleDto input);
        Task<ApiResult<RoleDto>> Delete(Guid id);
    }
}
