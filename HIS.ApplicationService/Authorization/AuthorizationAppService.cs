using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Systems.Login;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Authorization
{
    public class AuthorizationAppService : BaseAppService, IAuthorizationAppService
    {
        private readonly IConfiguration _config;

        public AuthorizationAppService(IConfiguration config)
        {
            _config = config;
        }

        public Task<ResultDto> ChangeWorkingBranch()
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<TokenResultDto>> LoginAsync(LoginDto request)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<TokenResultDto>> RefreshTokenAsync(TokenResultDto token)
        {
            throw new NotImplementedException();
        }


    }
}
