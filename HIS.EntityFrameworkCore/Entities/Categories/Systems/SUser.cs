using HIS.EntityFrameworkCore.BaseEntitys;
using HIS.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class SUser : Entity<Guid>
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public DateTime? Dob { get; set; }
        public UseTypes UseType { get; set; }
        public UserStatusTypes Status { get; set; }
        public Guid? GenderId { get; set; }
        public Guid? ProvinceId { get; set; }
        public Guid? District { get; set; }
        public Guid? WardsId { get; set; }

        public SGender? Gender { get; set; }

        public IList<SUserRole>? UserRoles { get; set; }

        public IList<SToken>? UserTokens { get; set; }
    }
}
