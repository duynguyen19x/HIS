using HIS.ApplicationService.Systems.LayoutTemplate.Dtos;
using HIS.ApplicationService.Systems.User.Dtos;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.User
{
    public interface ISYSUserAppService : IAppService
    {
        Task<PagedResultDto<SYSUserDto>> GetAllAsync(GetAllSYSUserInputDto input);

        Task<ResultDto<SYSUserDto>> GetAsync(Guid id);

        Task<ResultDto<SYSUserDto>> CreateOrUpdateAsync(SYSUserDto input);

        Task<ResultDto<SYSUserDto>> DeleteAsync(Guid id);
    }
}
