using HIS.ApplicationService.Authorization.Dto;
using HIS.ApplicationService.Authorization.Dtos;
using HIS.ApplicationService.Systems.Users.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Systems.Login;

namespace HIS.ApplicationService.Authorization
{
    public interface IAuthorizationAppService : IAppService
    {
        Task<ResultDto<LoginResultDto>> LoginAsync(LoginDto request);
        Task<ResultDto<RefreshTokenResultDto>> RefreshTokenAsync(RefreshTokenDto token);

        /// <summary>
        /// Thay đổi chi nhánh làm việc.
        /// </summary>
        Task<ResultDto> ChangeWorkingBranch();
    }
}
