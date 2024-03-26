using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Systems.Login;

namespace HIS.ApplicationService.Authorization
{
    public interface IAuthorizationAppService : IAppService
    {
        Task<ResultDto<TokenResultDto>> LoginAsync(LoginDto request);
        Task<ResultDto<TokenResultDto>> RefreshTokenAsync(TokenResultDto token);
    }
}
