using HIS.EntityFrameworkCore.BaseEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class SRole : Entity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public IList<SRolePermissionBranch>? RolePermissions { get; set; }
        public IList<SUserRole>? UserRoles { get; set; }
    }
}
