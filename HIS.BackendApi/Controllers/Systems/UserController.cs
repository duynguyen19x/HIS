using HIS.ApplicationService.Systems.User;
using HIS.Dtos.Commons;
using HIS.Dtos.Systems.User;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ApiResultList<UserDto>> GetAll([FromQuery] GetAllUserInput input)
        {
            return await _userService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<UserDto>> GetById(Guid id)
        {
            return await _userService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<UserDto>> CreateOrEdit(UserDto input)
        {
            return await _userService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<UserDto>> Delete(Guid id)
        {
            return await _userService.Delete(id);
        }
    }
}
