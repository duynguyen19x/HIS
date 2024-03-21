using HIS.ApplicationService.Systems.Roles.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.System;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.System.Roles
{
    public class RoleAppService : BaseAppService, IRoleAppService
    {
        private readonly IRepository<Permission, string> _sysPermissionRepository;
        private readonly IRepository<Role, Guid> _sysRoleRepository;
        private readonly IRepository<RolePermissionMapping, Guid> _sysRolePermissionMapingRepository;

        public RoleAppService(
            IRepository<Permission, string> sysPermissionRepository,
            IRepository<Role, Guid> sysRoleRepository,
            IRepository<RolePermissionMapping, Guid> sysRolePermissionMapingRepository) 
        {
            _sysPermissionRepository = sysPermissionRepository;
            _sysRoleRepository = sysRoleRepository;
            _sysRolePermissionMapingRepository = sysRolePermissionMapingRepository;
        }

        public async Task<PagedResultDto<RoleDto>> GetAllAsync(GetAllRoleInputDto input)
        {
            var result = new PagedResultDto<RoleDto>();
            try
            {
                var filter = _sysRoleRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.RoleCodeFilter), x => x.Code == input.RoleCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.RoleNameFilter), x => x.Name == input.RoleNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);
                var pagedAndSorted = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<RoleDto>>(pagedAndSorted.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async Task<ResultDto<RoleDto>> GetAsync(Guid id)
        {
            var result = new ResultDto<RoleDto>();
            try
            {
                var entity = await _sysRoleRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<RoleDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async Task<ResultDto<RoleDto>> CreateOrUpdateAsync(RoleDto input)
        {
            if (Check.IsNullOrDefault(input.Id))
            {
                return await CreateAsync(input);
            }    
            else
            {
                return await UpdateAsync(input);
            }    
        }

        public async Task<ResultDto<RoleDto>> CreateAsync(RoleDto input)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultDto<RoleDto>> UpdateAsync(RoleDto input)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultDto<RoleDto>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        
    }
}
