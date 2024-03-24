using HIS.ApplicationService.System.Permissions.Dto;
using HIS.ApplicationService.Systems.Users.Dto;
using HIS.Core.Application.Services.Dto;
using HIS.EntityFrameworkCore.Entities.System;

namespace HIS.ApplicationService.Systems.Roles.Dto
{
    public class RoleDto : EntityDto<Guid?>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }

        /// <summary>
        /// danh sách quyền
        /// </summary>
        public IList<string> GrantedPermissions { get; set; }
    }
}
