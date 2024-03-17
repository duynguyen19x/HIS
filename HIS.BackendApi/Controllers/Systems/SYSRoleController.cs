using HIS.ApplicationService.Systems.Role;
using HIS.Dtos.Systems.Role;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Systems.Role.Dtos;

namespace HIS.BackendApi.Controllers.Systems
{
    [Route("api/[controller]")]
    [ApiController]
    public class SYSRoleController : ControllerBase
    {
        private readonly ISYSRoleAppService _sysRoleAppService;

        public SYSRoleController(ISYSRoleAppService sysRoleAppService)
        {
            _sysRoleAppService = sysRoleAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<SYSRoleDto>> GetAll([FromQuery] GetAllSYSRoleInputDto input)
        {
            return await _sysRoleAppService.GetAllAsync(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<SYSRoleDto>> GetById(Guid id)
        {
            return await _sysRoleAppService.GetAsync(id);
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<ResultDto<SYSRoleDto>> CreateOrUpdate(SYSRoleDto input)
        {
            return await _sysRoleAppService.CreateOrUpdateAsync(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<SYSRoleDto>> Delete(Guid input)
        {
            return await _sysRoleAppService.DeleteAsync(input);
        }
    }
}
