using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.System.Roles;
using HIS.ApplicationService.Systems.Roles.Dto;

namespace HIS.BackendApi.Controllers.Systems
{
    [Route("api/[controller]")]
    [ApiController]
    public class SYSRoleController : ControllerBase
    {
        private readonly IRoleAppService _sysRoleAppService;

        public SYSRoleController(IRoleAppService sysRoleAppService)
        {
            _sysRoleAppService = sysRoleAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<RoleDto>> GetAll([FromQuery] GetAllRoleInputDto input)
        {
            return await _sysRoleAppService.GetAllAsync(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<RoleDto>> GetById(Guid id)
        {
            return await _sysRoleAppService.GetAsync(id);
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<ResultDto<RoleDto>> CreateOrUpdate(RoleDto input)
        {
            return await _sysRoleAppService.CreateOrUpdateAsync(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<RoleDto>> Delete(Guid input)
        {
            return await _sysRoleAppService.DeleteAsync(input);
        }
    }
}
