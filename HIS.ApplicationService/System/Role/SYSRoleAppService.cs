﻿using HIS.ApplicationService.Systems.Role.Dtos;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.System;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Systems.Role
{
    public class SYSRoleAppService : BaseAppService, ISYSRoleAppService
    {
        private readonly IRepository<SYSPermission, string> _sysPermissionRepository;
        private readonly IRepository<SYSRole, Guid> _sysRoleRepository;
        private readonly IRepository<SYSRolePermissionMapping, Guid> _sysRolePermissionMapingRepository;

        public SYSRoleAppService(
            IRepository<SYSPermission, string> sysPermissionRepository,
            IRepository<SYSRole, Guid> sysRoleRepository,
            IRepository<SYSRolePermissionMapping, Guid> sysRolePermissionMapingRepository) 
        {
            _sysPermissionRepository = sysPermissionRepository;
            _sysRoleRepository = sysRoleRepository;
            _sysRolePermissionMapingRepository = sysRolePermissionMapingRepository;
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
            var result = new ResultDto<SYSRoleDto>();
            try
            {
                var entity = await _sysRoleRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<SYSRoleDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async Task<ResultDto<SYSRoleDto>> CreateOrUpdateAsync(SYSRoleDto input)
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

        public async Task<ResultDto<SYSRoleDto>> CreateAsync(SYSRoleDto input)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultDto<SYSRoleDto>> UpdateAsync(SYSRoleDto input)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultDto<SYSRoleDto>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        
    }
}