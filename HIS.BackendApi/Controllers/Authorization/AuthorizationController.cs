using HIS.ApplicationService.Authorization;
using HIS.ApplicationService.Authorization.Dto;
using HIS.ApplicationService.Authorization.Dtos;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Systems.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Authorization
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private readonly IAuthorizationAppService _authorizationAppService;

        public AuthorizationController(IAuthorizationAppService authorizationAppService)
        {
            _authorizationAppService = authorizationAppService;
        }

        [HttpPost("Login")]
        public async Task<ResultDto<LoginResultDto>> LoginAsync(LoginDto request)
        {
            return await _authorizationAppService.LoginAsync(request);
        }

        [HttpPost("RefreshToken")]
        public async Task<ResultDto<RefreshTokenResultDto>> RefreshTokenAsync(RefreshTokenDto request)
        {
            return await _authorizationAppService.RefreshTokenAsync(request);
        }
    }
}
