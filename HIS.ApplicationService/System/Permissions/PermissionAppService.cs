using AutoMapper.Internal.Mappers;
using HIS.ApplicationService.System.Permissions.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities.System;
using HIS.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.System.Permissions
{
    public class PermissionAppService : BaseAppService, IPermissionAppService
    {
        private readonly IRepository<Permission, string> _permissionRepository;

        public PermissionAppService(IRepository<Permission, string> permissionRepository) 
        {
            _permissionRepository = permissionRepository;
        }

        public async Task<ListResultDto<PermissionDto>> GetAllAsync()
        {
            var permissions = await _permissionRepository.GetAllListAsync();
            return new ListResultDto<PermissionDto>(ObjectMapper.Map<List<PermissionDto>>(permissions).OrderBy(p => p.Name).ToList());
        }

    }
}
