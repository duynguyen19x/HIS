using HIS.Core.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    /// <summary>
    /// Vai trò và quyền hạn.
    /// </summary>
    [Table("SYSRolePermissionMaping")]
    public class SYSRolePermissionMaping : Entity<Guid>
    {
        public Guid RoleID { get; set; }

        [ForeignKey(nameof(RoleID))]
        public SYSRole RoleFk { get; set; }

        public string PermissionID { get; set; }

        [ForeignKey(nameof(PermissionID))]
        public SYSPermission PermissionFk { get; set; }

    }
}
