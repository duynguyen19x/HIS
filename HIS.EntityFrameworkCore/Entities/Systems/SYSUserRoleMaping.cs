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
    public class SYSUserRoleMaping : Entity<Guid>
    {
        public Guid UserID { get; set; }

        public Guid RoleID { get; set; }

        public Guid? BranchID { get; set; }

        [ForeignKey("UserID")]
        public SYSUser UserFk { get; set; }

        [ForeignKey("RoleID")]
        public SYSRole RoleFk { get; set; }

        [ForeignKey("BranchID")]
        public DIBranch BranchFk { get; set; }
    }
}
