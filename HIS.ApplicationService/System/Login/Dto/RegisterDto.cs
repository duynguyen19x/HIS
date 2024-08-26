using HIS.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Systems.Login
{
    public class RegisterDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime? BirthDate { get; set; }
        public UseTypes UseType { get; set; }
        public UserStatusTypes Status { get; set; }
        public int? GenderId { get; set; }
        public Guid? ProvinceId { get; set; }
        public Guid? District { get; set; }
        public Guid? WardsId { get; set; }
    }
}
