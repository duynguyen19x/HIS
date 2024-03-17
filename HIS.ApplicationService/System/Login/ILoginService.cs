using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Systems.Login;

namespace HIS.ApplicationService.Systems.Login
{
    public interface ILoginService
    {
        Task<ResultDto<TokenResultDto>> Authenticate(LoginDto request);
        Task<ResultDto<TokenResultDto>> RefreshToken(TokenResultDto token);
        Task<ResultDto<bool>> Register(RegisterDto request);
    }
}
