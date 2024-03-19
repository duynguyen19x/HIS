using HIS.ApplicationService.System.Authorization.Dtos;
using HIS.ApplicationService.Systems.Authorization.Dtos;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Systems.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.Authorization
{
    public interface IAuthorizationAppService : IAppService
    {
        Task<ResultDto<TokenResultDto>> LoginAsync(LoginDto request);
        Task<ResultDto<TokenResultDto>> RefreshTokenAsync(TokenResultDto token);
    }
}
