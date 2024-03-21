using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.System
{
    /// <summary>
    /// Vai trò và quyền hạn.
    /// </summary>
    [Table("SYSRolePermissionMapping")]
    public class SYSRolePermissionMapping : Entity<Guid>
    {
        public Guid RoleId { get; set; }

        [MaxLength(255)]
        public string PermissionId { get; set; }

        [ForeignKey(nameof(PermissionId))]
        public virtual SYSPermission PermissionFk { get; set; }

        [ForeignKey(nameof(RoleId))]
        public virtual Role RoleFk { get; set; }

    }
}
