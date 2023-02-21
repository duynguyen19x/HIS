using HIS.EntityFrameworkCore.BaseEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class Role : Entity<Guid>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public List<RolePermission>? RolePermissions { get; set; }
        public List<UserRole>? UserRoles { get; set; }
    }
}
