using HIS.ApplicationService.Systems.Roles.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.Dtos.Dictionaries.Branchs;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.System;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.System.Roles
{
    public class RoleAppService : BaseAppService, IRoleAppService
    {
        private readonly IRepository<Permission, string> _permissionRepository;
        private readonly IRepository<Role, Guid> _roleRepository;
        private readonly IRepository<RolePermissionMapping, Guid> _rolePermissionMapingRepository;

        public RoleAppService(
            IRepository<Permission, string> permissionRepository,
            IRepository<Role, Guid> roleRepository,
            IRepository<RolePermissionMapping, Guid> rolePermissionMapingRepository) 
        {
            _permissionRepository = permissionRepository;
            _roleRepository = roleRepository;
            _rolePermissionMapingRepository = rolePermissionMapingRepository;
        }

        public async Task<PagedResultDto<RoleDto>> GetAllAsync(GetAllRoleInputDto input)
        {
            var result = new PagedResultDto<RoleDto>();
            try
            {
                var filter = _roleRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
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
                var entity = await _roleRepository.GetAsync(id);

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
            var result = new ResultDto<RoleDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var role = ObjectMapper.Map<Role>(input);

                    await _roleRepository.InsertAsync(role);
                    unitOfWork.Complete();

                    result.Result = input;
                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async Task<ResultDto<RoleDto>> UpdateAsync(RoleDto input)
        {
            var result = new ResultDto<RoleDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<Role>(input);

                    await _roleRepository.InsertAsync(entity);
                    unitOfWork.Complete();

                    result.Result = input;
                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async Task<ResultDto<RoleDto>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        
    }
}
