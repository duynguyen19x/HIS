using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Systems.Role;
using HIS.EntityFrameworkCore;
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

        public async Task<PagedResultDto<RoleDto>> GetAll(GetAllRoleInput input)
        {
            var result = new PagedResultDto<RoleDto>();
            try
            {
                result.IsSucceeded = true;
                result.Result = (from r in _dbContext.Roles
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
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public async Task<ResultDto<RoleDto>> GetById(Guid id)
        {
            var result = new ResultDto<RoleDto>();

            var role = _dbContext.Roles.SingleOrDefault(s => s.Id == id);
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

        public async Task<ResultDto<RoleDto>> CreateOrEdit(RoleDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        private async Task<ResultDto<RoleDto>> Create(RoleDto input)
        {
            var result = new ResultDto<RoleDto>();
            await _dbContext.Roles.AddAsync(new EntityFrameworkCore.Entities.Systems.Role()
            {

            });

            _dbContext.SaveChanges();
            return result;
        }

        private Task<ResultDto<RoleDto>> Update(RoleDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<RoleDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        
    }
}
