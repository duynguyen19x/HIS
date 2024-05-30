using HIS.Core.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Người dùng và vai trò.
    /// </summary>
    [Table("SUserRoleMapping")]
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
