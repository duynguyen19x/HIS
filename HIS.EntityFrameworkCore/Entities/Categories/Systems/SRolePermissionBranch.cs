using HIS.EntityFrameworkCore.Entities.Dictionaries;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class SRolePermissionBranch
    {
        public Guid? RoleId { get; set; }
        public Guid? PermissionId { get; set; }
        public Guid? BranchId { get; set; }

        public SRole Role { get; set; }
        public SPermission Permission { get; set; }
        public SBranch Branch { get; set; }
    }
}
