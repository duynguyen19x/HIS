using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.System
{
    /// <summary>
    /// Người dùng và vai trò.
    /// </summary>
    [Table("SYSUserRoleMapping")]
    public class UserRoleMapping : Entity<Guid>
    {
        public virtual Guid UserId { get; set; }

        public virtual Guid RoleId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role RoleFk { get; set; }

        [ForeignKey("UserId")]
        public virtual User UserFk { get; set; }

        public UserRoleMapping() { }

        public UserRoleMapping(Guid userId, Guid roleId)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            RoleId = roleId;
        }
    }
}
