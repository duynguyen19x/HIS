using HIS.EntityFrameworkCore.BaseEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class UserRole 
    {
        public Guid? UserId { get; set; }
        public Guid? RoleId { get; set; }

        public User? User { get; set; }
        public Role? Role { get; set; }
    }
}
