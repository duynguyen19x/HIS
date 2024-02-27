using HIS.ApplicationService.Systems.Permission.Dtos;
using HIS.ApplicationService.Systems.Role.Dtos;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Linq.Extensions;
using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.Permission
{
    public class SYSPermissionAppService : BaseAppService, ISYSPermissionAppService
    {
        private readonly IRepository<SYSPermission, string> _sysPermissionRepository;

        public SYSPermissionAppService(
            IRepository<SYSPermission, string> sysPermissionRepository)
        {
            _sysPermissionRepository = sysPermissionRepository;
        }

        public async Task<PagedResultDto<SYSPermissionDto>> GetAllAsync(GetAllSYSPermissionInputDto input)
        {
            var result = new PagedResultDto<SYSPermissionDto>();
            try
            {
                var filter = _sysPermissionRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.PermissionNameFilter), x => x.Name == input.PermissionNameFilter);
                var pagedAndSorted = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<SYSPermissionDto>>(pagedAndSorted.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }
    }
}
