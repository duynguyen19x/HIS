using HIS.ApplicationService.Systems.Role;
using HIS.Dtos.Commons;
using HIS.Dtos.Systems.Role;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace HIS.BackendApi.Controllers.Systems.Role
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService) 
        {
            _roleService = roleService;
        }

        [HttpGet]
        public async Task<ApiResultList<SRoleDto>> GetAll(GetAllSRoleInputDto input)
        {
            return await _roleService.GetAll(input);
        }

        [HttpGet]
        public async Task<ApiResult<SRoleDto>> GetById(Guid id)
        {
            return await _roleService.GetById(id);
        }

    }
}
