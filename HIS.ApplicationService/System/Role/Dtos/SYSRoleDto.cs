using HIS.ApplicationService.Systems.Permission.Dtos;
using HIS.Core.Application.Services.Dto;
using HIS.EntityFrameworkCore.Entities.System;

namespace HIS.ApplicationService.Systems.Role.Dtos
{
    public class SYSRoleDto : EntityDto<Guid>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }

        public IList<SYSPermissionDto> Permissions { get; set; }

        public IList<SYSUser> Users { get; set; }
    }
}
