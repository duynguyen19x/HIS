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

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    /// <summary>
    /// Người dùng và vai trò.
    /// </summary>
    [Table("SYSUserRoleMapping")]
    public class SYSUserRoleMapping : Entity<Guid>
    {
        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }

        public Guid? BranchId { get; set; }


        [ForeignKey(nameof(UserId))]
        [Ignore]
        public SYSUser UserFk { get; set; }

        [ForeignKey(nameof(RoleId))]
        [Ignore]
        public SYSRole RoleFk { get; set; }

        [ForeignKey(nameof(BranchId))]
        [Ignore]
        public DIBranch BranchFk { get; set; }
    }
}
