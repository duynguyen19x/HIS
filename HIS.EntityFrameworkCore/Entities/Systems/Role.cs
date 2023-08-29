using HIS.Core.Entities;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    public class Role : Entity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public bool IsSystem { get; set; }

        public IList<RolePermissionBranch> RolePermissions { get; set; }
        public IList<UserRole> UserRoles { get; set; }
    }
}
