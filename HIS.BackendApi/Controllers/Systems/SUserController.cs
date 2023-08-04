using HIS.ApplicationService.Dictionaries.Room;
using HIS.ApplicationService.Systems.User;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Room;
using HIS.Dtos.Systems.User;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Systems
{
    [Route("api/[controller]")]
    [ApiController]
    public class SUserController : ControllerBase
    {
        private readonly IUserService _userService;

        public SUserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SUserDto>> GetAll([FromQuery] GetAllSUserInput input)
        {
            return await _userService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SUserDto>> GetById(Guid id)
        {
            return await _userService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SUserDto>> CreateOrEdit(SUserDto input)
        {
            return await _userService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<SUserDto>> Delete(Guid id)
        {
            return await _userService.Delete(id);
        }
    }
}
