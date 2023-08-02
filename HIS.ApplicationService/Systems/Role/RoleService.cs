using HIS.Dtos.Commons;
using HIS.Dtos.Systems.Role;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.Role
{
    public class RoleService : IRoleService
    {
        private readonly HISDbContext _dbContext;
        private readonly IConfiguration _config;

        public RoleService(HISDbContext dbContext, IConfiguration config)
        {
            _dbContext = dbContext;
            _config = config;
        }

        public async Task<ApiResultList<SRoleDto>> GetAll(GetAllSRoleInput input)
        {
            var result = new ApiResultList<SRoleDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SRoles
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new SRoleDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Description = r.Description,
                                     Inactive = r.Inactive
                                 }).ToList();
                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<SRoleDto>> GetById(Guid id)
        {
            var result = new ApiResult<SRoleDto>();

            var role = _dbContext.SRoles.SingleOrDefault(s => s.Id == id);
            if (role != null)
            {
                result.Result = new SRoleDto()
                {
                    Id = role.Id,
                    Code = role.Code,
                    Name = role.Name,
                    Description = role.Description,
                    Inactive = role.Inactive
                };
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<SRoleDto>> CreateOrEdit(SRoleDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        private async Task<ApiResult<SRoleDto>> Create(SRoleDto input)
        {
            var result = new ApiResult<SRoleDto>();
            await _dbContext.SRoles.AddAsync(new EntityFrameworkCore.Entities.Categories.SRole()
            {

            });

            _dbContext.SaveChanges();
            return result;
        }

        private Task<ApiResult<SRoleDto>> Update(SRoleDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<SRoleDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        
    }
}
