using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.System
{
    /// <summary>
    /// Người dùng và vai trò.
    /// </summary>
    [Table("SYSUserRoleMapping")]
    public class SYSUserRoleMapping : Entity<Guid>
    {
        public virtual Guid UserId { get; set; }

        public virtual Guid RoleId { get; set; }

        public virtual Guid? BranchId { get; set; }


        [ForeignKey(nameof(UserId))]
        [Ignore]
        public virtual User UserFk { get; set; }

        [ForeignKey(nameof(RoleId))]
        [Ignore]
        public virtual Role RoleFk { get; set; }

        [ForeignKey(nameof(BranchId))]
        [Ignore]
        public virtual DIBranch BranchFk { get; set; }
    }
}
