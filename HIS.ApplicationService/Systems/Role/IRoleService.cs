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
        Task<ApiResultList<SRoleDto>> GetAll(GetAllSRoleInputDto input);
        Task<ApiResult<SRoleDto>> GetById(Guid id);
        Task<ApiResult<SRoleDto>> CreateOrEdit(SRoleDto input);
        Task<ApiResult<SRoleDto>> Delete(Guid id);
    }
}
