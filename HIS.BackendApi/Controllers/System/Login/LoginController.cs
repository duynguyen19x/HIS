using HIS.ApplicationService.Systems.Login;
using HIS.Dtos.Systems.Login;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Authorization.Dto;

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
        public async Task<ResultDto<TokenResultDto>> Authenticate(LoginDto request)
        {
            return await _loginService.Authenticate(request);
        }

        [HttpPost("Register")]
        public async Task<ResultDto<bool>> Register(RegisterDto request)
        {
            return await _loginService.Register(request);
        }

        [HttpPost("RefreshToken")]
        public async Task<ResultDto<TokenResultDto>> RefreshToken(TokenResultDto token)
        {
            return await _loginService.RefreshToken(token);
        }
    }
}
