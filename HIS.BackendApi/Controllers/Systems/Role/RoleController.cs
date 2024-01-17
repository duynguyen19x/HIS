using HIS.Core.Services.Dto;
using HIS.ApplicationService.Systems.Role;
using HIS.Dtos.Systems.Role;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<PagedResultDto<RoleDto>> GetAll([FromQuery] GetAllRoleInput input)
        {
            return await _roleService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<RoleDto>> GetById(Guid id)
        {
            return await _roleService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<RoleDto>> CreateOrEdit(RoleDto input)
        {
            return await _roleService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<RoleDto>> Delete(Guid input)
        {
            return await _roleService.Delete(input);
        }
    }
}
