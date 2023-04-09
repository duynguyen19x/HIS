using HIS.Dtos.Commons;
using HIS.Dtos.Systems.Role;
using HIS.EntityFrameworkCore.DbContexts;
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
        private readonly HIS_DbContext _dbContext;
        private readonly IConfiguration _config;

        public RoleService(HIS_DbContext dbContext, IConfiguration config)
        {
            _dbContext = dbContext;
            _config = config;
        }


        public async Task<ApiResultList<SRoleDto>> GetAll(GetAllSRoleInputDto input)
        {
            var result = new ApiResultList<SRoleDto>();
    
            //_dbContext.SRoles.WhereW

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

        public Task<ApiResult<SRoleDto>> CreateOrEdit(SRoleDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<SRoleDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        
    }
}
