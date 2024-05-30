using HIS.ApplicationService.System.Permissions.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities;

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
