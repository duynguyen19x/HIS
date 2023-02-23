using HIS.ApplicationService.Systems.Login;
using HIS.Dtos.Systems.Login;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Systems.Login
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost("Authenticate")]
        public async Task<ApiResult<TokenResultDto>> Authenticate(LoginDto request)
        {
            return await _loginService.Authenticate(request);
        }

        [HttpPost("Register")]
        public async Task<ApiResult<bool>> Register(RegisterDto request)
        {
            return await _loginService.Register(request);
        }
    }
}
