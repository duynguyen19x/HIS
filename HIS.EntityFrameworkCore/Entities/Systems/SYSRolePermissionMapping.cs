using AutoMapper.Configuration.Annotations;
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
        public virtual Guid RoleId { get; set; }

        public virtual Guid PermissionId { get; set; }

        [ForeignKey(nameof(PermissionId))]
        [Ignore]
        public virtual SYSPermission PermissionFk { get; set; }

        [ForeignKey(nameof(RoleId))]
        [Ignore]
        public virtual SYSRole RoleFk { get; set; }

    }
}
