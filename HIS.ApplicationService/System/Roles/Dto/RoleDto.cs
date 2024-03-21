using HIS.ApplicationService.System.Roles.Dto;
using HIS.ApplicationService.Systems.Users.Dto;
using HIS.Core.Application.Services.Dto;
using HIS.EntityFrameworkCore.Entities.System;

namespace HIS.ApplicationService.Systems.Roles.Dto
{
    public class RoleDto : EntityDto<Guid>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }

        public IList<PermissionDto> Permissions { get; set; }

        public IList<UserDto> Users { get; set; }
    }
}
