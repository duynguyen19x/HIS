using HIS.ApplicationService.Systems.Permission.Dtos;
using HIS.ApplicationService.Systems.Role.Dtos;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.Permission
{
    public interface ISYSPermissionAppService : IAppService
    {
        Task<PagedResultDto<SYSPermissionDto>> GetAllAsync(GetAllSYSPermissionInputDto input);
    }
}
