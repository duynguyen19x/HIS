using HIS.Core.Entities;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    public class SPermission : Entity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public List<SRolePermissionBranch> RolePermissions { get; set; }
    }
}
