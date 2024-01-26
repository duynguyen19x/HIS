using HIS.ApplicationService.Systems.User;
using HIS.Dtos.Systems.User;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;

namespace HIS.BackendApi.Controllers.Systems
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<UserDto>> GetAll([FromQuery] GetAllUserInput input)
        {
            return await _userService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<UserDto>> GetById(Guid id)
        {
            return await _userService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<UserDto>> CreateOrEdit(UserDto input)
        {
            return await _userService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<UserDto>> Delete(Guid id)
        {
            return await _userService.Delete(id);
        }
    }
}
