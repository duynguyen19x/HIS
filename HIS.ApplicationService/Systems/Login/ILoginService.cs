using HIS.Dtos.Systems.Login;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.Login
{
    public interface ILoginService
    {
        Task<ApiResult<TokenResultDto>> Authenticate(LoginDto request);
        Task<ApiResult<bool>> Register(RegisterDto request);
    }
}
