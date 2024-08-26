using HIS.Core.Domain.Entities.Auditing;
using HIS.Utilities.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    [Table("SUsers")]
    public class User : FullAuditedEntity<Guid>
    {
        public const string DefaultPassword = "123qwe";
        public const string AdminUserName = "admin";

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
        /// Họ và tên người dùng
        /// </summary>
        [MaxLength(255)]
        [Required]
        public virtual string FullName { get; set; }

        /// <summary>
        /// Thư điện tử
        /// </summary>
        [MaxLength(255)]
        public virtual string Email { get; set; }

        /// <summary>
        /// Điện thoại
        /// </summary>
        [MaxLength(50)]
        public virtual string Tel { get; set; }

        /// <summary>
        /// Điện thoại di động
        /// </summary>
        [MaxLength(50)]
        public virtual string Mobile { get; set; }

        /// <summary>
        /// Diễn giải
        /// </summary>
        [MaxLength(255)]
        public virtual string Description { get; set; }

        /// <summary>
        /// Chi nhánh khởi tạo tài khoản người dùng (mặc định quyền đăng nhập vào chi nhánh khi tài khoản không bị khóa)
        /// </summary>
        public virtual Guid? BranchId { get; set; }

        /// <summary>
        /// Chi nhánh người dùng làm việc cuối cùng (mặc định là chi nhánh khởi tạo người dùng)
        /// </summary>
        public virtual Guid? LastWorkingBranchId { get; set; }

        /// <summary>
        /// Số lần đăng nhập thất bại (khi quá số lần cho phép trong cấu hình thì khóa tài khoản, kho đăng nhập thành công thì làm gán bằng 0)
        /// </summary>
        public virtual int AccessFailedCount { get; set; }

        /// <summary>
        /// Khóa tài khoản người dùng
        /// </summary>
        public virtual bool Inactive { get; set; }

        public string Address { get; set; }

        public DateTime? BirthDate { get; set; }

        public UseTypes UseType { get; set; }

        public int? GenderId { get; set; }

        public Guid? ProvinceId { get; set; }

        public Guid? DistrictId { get; set; }

        public Guid? WardId { get; set; }

        [ForeignKey(nameof(BranchId))]
        public virtual Branch BranchFk { get; set; }

        [ForeignKey(nameof(GenderId))]
        public virtual Gender GenderFk { get; set; }

        [ForeignKey(nameof(ProvinceId))]
        public virtual Province ProvinceFk { get; set; }

        [ForeignKey(nameof(DistrictId))]
        public virtual Province DistrictFk { get; set; }

        [ForeignKey(nameof(WardId))]
        public virtual Province WardFk { get; set; }
    }
}
