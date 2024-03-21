using HIS.ApplicationService.System.Permissions.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.System.Permissions
{
    public interface IPermissionAppService : IAppService
    {
        Task<ListResultDto<PermissionDto>> GetAllAsync();
    }
}
