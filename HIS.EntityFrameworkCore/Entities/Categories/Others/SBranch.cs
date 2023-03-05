using HIS.EntityFrameworkCore.BaseEntitys;
using HIS.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class SBranch : Entity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public StatusTypes Status { get; set; }
        public Guid? ParentId { get; set; }

        public IList<SRolePermissionBranch> RolePermissions { get; set; }
    }
}
