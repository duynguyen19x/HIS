using HIS.ApplicationService.Systems.User;
using HIS.Dtos.Systems.User;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Systems.User.Dtos;

namespace HIS.BackendApi.Controllers.Systems
{
    [Route("api/[controller]")]
    [ApiController]
    public class SYSUserController : ControllerBase
    {
        private readonly ISYSUserAppService _sysUserAppService;

        public SYSUserController(ISYSUserAppService sysUserAppService)
        {
            _sysUserAppService = sysUserAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<SYSUserDto>> GetAll([FromQuery] GetAllSYSUserInputDto input)
        {
            return await _sysUserAppService.GetAllAsync(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<SYSUserDto>> GetById(Guid id)
        {
            return await _sysUserAppService.GetAsync(id);
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<ResultDto<SYSUserDto>> CreateOrUpdate(SYSUserDto input)
        {
            return await _sysUserAppService.CreateOrUpdateAsync(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<SYSUserDto>> Delete(Guid id)
        {
            return await _sysUserAppService.DeleteAsync(id);
        }
    }
}
