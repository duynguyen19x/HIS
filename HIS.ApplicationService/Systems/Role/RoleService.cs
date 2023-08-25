using HIS.Dtos.Commons;
using HIS.Dtos.Systems.Role;
using HIS.EntityFrameworkCore.Entities.Systems;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

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

        public async Task<ApiResultList<RoleDto>> GetAll(GetAllRoleInput input)
        {
            var result = new ApiResultList<RoleDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SRoles
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new RoleDto()
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

        public async Task<ApiResult<RoleDto>> GetById(Guid id)
        {
            var result = new ApiResult<RoleDto>();

            var role = _dbContext.SRoles.SingleOrDefault(s => s.Id == id);
            if (role != null)
            {
                result.Result = new RoleDto()
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

        public async Task<ApiResult<RoleDto>> CreateOrEdit(RoleDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        private async Task<ApiResult<RoleDto>> Create(RoleDto input)
        {
            var result = new ApiResult<RoleDto>();
            await _dbContext.SRoles.AddAsync(new EntityFrameworkCore.Entities.Systems.Role()
            {

            });

            _dbContext.SaveChanges();
            return result;
        }

        private Task<ApiResult<RoleDto>> Update(RoleDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<RoleDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        
    }
}
