using HIS.ApplicationService.Systems.Role;
using HIS.Dtos.Commons;
using HIS.Dtos.Systems.Role;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet("GetAll")]
        public async Task<ApiResultList<RoleDto>> GetAll([FromQuery] GetAllRoleInput input)
        {
            return await _roleService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<RoleDto>> GetById(Guid id)
        {
            return await _roleService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<RoleDto>> CreateOrEdit(RoleDto input)
        {
            return await _roleService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<RoleDto>> Delete(Guid input)
        {
            return await _roleService.Delete(input);
        }
    }
}
