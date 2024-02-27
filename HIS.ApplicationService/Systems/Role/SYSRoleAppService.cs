using Azure;
using HIS.ApplicationService.Systems.Role.Dtos;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Linq.Extensions;
using HIS.Dtos.Dictionaries.Branchs;
using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.Role
{
    public class SYSRoleAppService : BaseAppService, ISYSRoleAppService
    {
        private readonly IRepository<SYSPermission, string> _sysPermissionRepository;
        private readonly IRepository<SYSRole, Guid> _sysRoleRepository;
        private readonly IRepository<SYSRolePermissionMaping, Guid> _sysRolePermissionMapingRepository;

        public SYSRoleAppService(
            IRepository<SYSPermission, string> sysPermissionRepository,
            IRepository<SYSRole, Guid> sysRoleRepository,
            IRepository<SYSRolePermissionMaping, Guid> sysRolePermissionMapingRepository) 
        {
            _sysPermissionRepository = sysPermissionRepository;
            _sysRoleRepository = sysRoleRepository;
            _sysRolePermissionMapingRepository = sysRolePermissionMapingRepository;
        }

        public Task<ResultDto<SYSRoleDto>> CreateOrUpdateAsync(SYSRoleDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<SYSRoleDto>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResultDto<SYSRoleDto>> GetAllAsync(GetAllSYSRoleInputDto input)
        {
            var result = new PagedResultDto<SYSRoleDto>();
            try
            {
                var filter = _sysRoleRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.RoleCodeFilter), x => x.Code == input.RoleCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.RoleNameFilter), x => x.Name == input.RoleNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);
                var pagedAndSorted = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<SYSRoleDto>>(pagedAndSorted.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async Task<ResultDto<SYSRoleDto>> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
