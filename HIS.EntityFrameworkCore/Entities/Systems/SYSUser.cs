using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    [Table("SYSUser")]
    public class SYSUser : AuditedEntity<Guid>
    {
        /// <summary>
        /// Tên người dùng
        /// </summary>
        [MaxLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Tên đăng nhập
        /// </summary>
        [MaxLength(50)]
        public string Username { get; set; }

        /// <summary>
        /// Mật khẩu
        /// </summary>
        [MaxLength(255)]
        public string Password { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Tel { get; set; }

        [MaxLength(50)]
        public string Mobile { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public Guid? EmployeeId { get; set; }

        public bool Inactive { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [Ignore]
        public virtual DIEmployee Employee { get; set; }

        //public string UserName { get; set; }

        //public string Password { get; set; }

        //public string PhoneNumber { get; set; }

        //public string Email { get; set; }

        //public string FirstName { get; set; }

        //public string LastName { get; set; }

        //public string Address { get; set; }

        //public DateTime? Dob { get; set; }

        //public UseTypes UseType { get; set; }

        //public UserStatusTypes Status { get; set; }

        //public Guid? GenderId { get; set; }

        //public Guid? ProvinceId { get; set; }

        //public Guid? DistrictId { get; set; }

        //public Guid? WardId { get; set; }

        //public IList<UserRole> UserRoles { get; set; }
        public IList<SToken> UserTokens { get; set; }
    }
}
