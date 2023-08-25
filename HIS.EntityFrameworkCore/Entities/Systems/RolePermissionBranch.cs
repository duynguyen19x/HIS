using HIS.EntityFrameworkCore.Entities.Dictionaries;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    public class RolePermissionBranch
    {
        public Guid? RoleId { get; set; }
        public Guid? PermissionId { get; set; }
        public Guid? BranchId { get; set; }

        public Role Role { get; set; }
        public Permission Permission { get; set; }
        public Branch Branch { get; set; }
    }
}
