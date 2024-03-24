using HIS.ApplicationService.Systems.Roles.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.Dtos.Dictionaries.Branchs;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.System;
using HIS.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.System.Roles
{
    public class RoleAppService : BaseAppService, IRoleAppService
    {
        private readonly IBulkRepository<Permission, string> _permissionRepository;
        private readonly IBulkRepository<Role, Guid> _roleRepository;
        private readonly IBulkRepository<RolePermissionMapping, Guid> _rolePermissionMapingRepository;
        private readonly IBulkRepository<UserRoleMapping, Guid> _userRoleMappingRepository;

        public RoleAppService(
            IBulkRepository<Permission, string> permissionRepository,
            IBulkRepository<Role, Guid> roleRepository,
            IBulkRepository<RolePermissionMapping, Guid> rolePermissionMapingRepository,
            IBulkRepository<UserRoleMapping, Guid> userRoleMappingRepository) 
        {
            _permissionRepository = permissionRepository;
            _roleRepository = roleRepository;
            _rolePermissionMapingRepository = rolePermissionMapingRepository;
            _userRoleMappingRepository = userRoleMappingRepository;
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

                    // quyền hạn
                    var grantedPermissionMapping = new List<RolePermissionMapping>();
                    if (input.GrantedPermissions != null)
                    {
                        foreach (var permission in input.GrantedPermissions)
                        {
                            grantedPermissionMapping.Add(new RolePermissionMapping(role.Id, permission));
                        }
                    }    
                    

                    await _roleRepository.InsertAsync(role);
                    if (grantedPermissionMapping.Any())
                        await _rolePermissionMapingRepository.BulkInsertAsync(grantedPermissionMapping);

                    unitOfWork.Complete();
                    result.Success(input);
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
                    var role = await _roleRepository.GetAsync(input.Id.Value);
                    var grantedPermissionMapping = await _rolePermissionMapingRepository.GetAllListAsync(x => x.RoleId == input.Id);

                    // xử lý dữ liệu
                    ObjectMapper.Map(input, role);

                    var newGrantedPermissionMapping = new List<RolePermissionMapping>();
                    if (input.GrantedPermissions != null)
                    {
                        foreach (var permission in input.GrantedPermissions)
                        {
                            var granted = grantedPermissionMapping.RemoveAll(x => x.PermissionId == permission);
                            if (granted < 1)
                            {
                                newGrantedPermissionMapping.Add(new RolePermissionMapping(role.Id, permission));
                            }
                        }
                    }

                    // xóa những quyền ko được sử dụng
                    if (grantedPermissionMapping.Any())
                        await _rolePermissionMapingRepository.BulkDeleteAsync(grantedPermissionMapping);

                    // lưu
                    //await _roleRepository.UpdateAsync(role);
                    if (newGrantedPermissionMapping.Any())
                        await _rolePermissionMapingRepository.BulkInsertAsync(newGrantedPermissionMapping);

                    unitOfWork.Complete();
                    result.Success(input);
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
            var result = new ResultDto<RoleDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                try
                {
                    var role = await _roleRepository.GetAsync(id);
                    var rolePermissionMapping = await _rolePermissionMapingRepository.GetAllListAsync(x=>x.RoleId == role.Id);
                    var userRoleMapping = await _userRoleMappingRepository.GetAllListAsync(x=>x.RoleId == role.Id);

                    await _rolePermissionMapingRepository.BulkDeleteAsync(rolePermissionMapping);
                    await _userRoleMappingRepository.BulkDeleteAsync(userRoleMapping);
                    await _roleRepository.DeleteAsync(role);

                    unitOfWork.Complete();
                    result.Success(null);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

    }
}
