using HIS.Core.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    /// <summary>
    /// Vai trò và quyền hạn.
    /// </summary>
    [Table("SYSRolePermissionMapping")]
    public class SYSRolePermissionMapping : Entity<Guid>
    {
        public Guid RoleId { get; set; }

        public Guid PermissionId { get; set; }

        [ForeignKey(nameof(PermissionId))]
        public SYSPermission PermissionFk { get; set; }

        [ForeignKey(nameof(RoleId))]
        public SYSRole RoleFk { get; set; }

    }
}
