using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.System
{
    [Table("SYSUser")]
    public class SYSUser : AuditedEntity<Guid>
    {
        /// <summary>
        /// Họ và tên người dùng
        /// </summary>
        [MaxLength(255)]
        [Required]
        public virtual string FullName { get; set; }

        /// <summary>
        /// Tên người dùng
        /// </summary>
        [MaxLength(128)]
        public virtual string FirstName { get; set; }

        /// <summary>
        /// Họ và tên đệm
        /// </summary>
        [MaxLength(128)]
        public virtual string LastName { get; set; }

        /// <summary>
        /// Tên đăng nhập
        /// </summary>
        [MaxLength(50)]
        public virtual string Username { get; set; }

        /// <summary>
        /// Mật khẩu
        /// </summary>
        [MaxLength(255)]
        public virtual string Password { get; set; }

        [MaxLength(255)]
        public virtual string Email { get; set; }

        [MaxLength(50)]
        public virtual string Tel { get; set; }

        [MaxLength(50)]
        public virtual string Mobile { get; set; }

        [MaxLength(255)]
        public virtual string Description { get; set; }

        public virtual Guid? EmployeeId { get; set; }

        public virtual bool Inactive { get; set; }

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
        public virtual IList<SToken> UserTokens { get; set; }
    }
}
