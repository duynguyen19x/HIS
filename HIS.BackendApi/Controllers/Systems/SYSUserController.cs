using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.System.Users;
using HIS.ApplicationService.Systems.Users.Dto;

namespace HIS.BackendApi.Controllers.Systems
{
    [Route("api/[controller]")]
    [ApiController]
    public class SYSUserController : ControllerBase
    {
        private readonly IUserAppService _sysUserAppService;

        public SYSUserController(IUserAppService sysUserAppService)
        {
            _sysUserAppService = sysUserAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<UserDto>> GetAll([FromQuery] GetAllUserInputDto input)
        {
            return await _sysUserAppService.GetAllAsync(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<UserDto>> GetById(Guid id)
        {
            return await _sysUserAppService.GetAsync(id);
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<ResultDto<UserDto>> CreateOrUpdate(UserDto input)
        {
            return await _sysUserAppService.CreateOrUpdateAsync(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<UserDto>> Delete(Guid id)
        {
            return await _sysUserAppService.DeleteAsync(id);
        }
    }
}
