using HIS.Core.Domain.Entities;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    public class Permission : Entity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public List<RolePermissionBranch> RolePermissions { get; set; }
    }
}
