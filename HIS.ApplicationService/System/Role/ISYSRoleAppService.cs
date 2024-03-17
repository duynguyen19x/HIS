using HIS.ApplicationService.Systems.Role.Dtos;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.Branchs;
using HIS.EntityFrameworkCore.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.Role
{
    public interface ISYSRoleAppService : IAppService
    {
        Task<PagedResultDto<SYSRoleDto>> GetAllAsync(GetAllSYSRoleInputDto input);

        Task<ResultDto<SYSRoleDto>> GetAsync(Guid id);

        Task<ResultDto<SYSRoleDto>> CreateOrUpdateAsync(SYSRoleDto input);

        Task<ResultDto<SYSRoleDto>> DeleteAsync(Guid id);

    }
}
