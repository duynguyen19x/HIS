using HIS.Core.Entities;
using HIS.Utilities.Enums;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    public class User : Entity<Guid>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime? Dob { get; set; }
        public UseTypes UseType { get; set; }
        public UserStatusTypes Status { get; set; }
        public Guid? GenderId { get; set; }
        public Guid? ProvinceId { get; set; }
        public Guid? DistrictId { get; set; }
        public Guid? WardId { get; set; }

        public IList<UserRole> UserRoles { get; set; }
        public IList<SToken> UserTokens { get; set; }
    }
}
