using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Chi nhánh.
    /// </summary>
    [Table("DIBranch")]
    public class DIBranch : AuditedEntity<Guid>
    {
        /// <summary>
        /// Mã chi nhánh
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        /// <summary>
        /// Tên chi nhánh
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// Mã khám chữa bệnh ban đầu
        /// </summary>
        [MaxLength(255)]
        public string MediOrgCode { get; set; }

        /// <summary>
        /// Mã KCBBĐ đúng tuyến (ngăn cách bởi dấu ;)
        /// </summary>
        [MaxLength(4000)]
        public string MediOrgAcceptCode { get; set; }

        /// <summary>
        /// Hạng bệnh viện (hạng I, II, III và đặc biệt)
        /// </summary>
        [MaxLength(50)]
        public string Level { get; set; }

        /// <summary>
        /// Chuyên khoa
        /// </summary>
        [MaxLength(50)]
        public string Specialty { get; set; }

        /// <summary>
        /// Tuyến bệnh viện
        /// </summary>
        [MaxLength(50)]
        public string Line { get; set; }

        /// <summary>
        /// Tên đơn vị quản lý (sở y tế/bộ y tế)
        /// </summary>
        [MaxLength(50)]
        public string ParentOrganizationName { get; set; }

        /// <summary>
        /// Điện thoại
        /// </summary>
        [MaxLength(50)]
        public string Tel { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [MaxLength(50)]
        public string Email { get; set; }

        /// <summary>
        /// Địa chỉ (số nhà, thôn, xóm)
        /// </summary>
        [MaxLength(255)]
        public string Address { get; set; }

        /// <summary>
        /// Ghi chú
        /// </summary>
        [MaxLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Số thứ tự hiển thị
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// Khóa
        /// </summary>
        public bool Inactive { get; set; }

        /// <summary>
        /// Tỉnh, thành phố
        /// </summary>
        public Guid? ProvinceId { get; set; }

        [Ignore]
        [ForeignKey("ProvinceId")]
        public Province ProvinceFk { get; set; }

        /// <summary>
        /// Quận, huyện
        /// </summary>
        public Guid? DistrictId { get; set; }

        [Ignore]
        [ForeignKey("DistrictId")]
        public District DistrictFk { get; set; }

        /// <summary>
        /// Xã, phường
        /// </summary>
        public Guid? WardId { get; set; }

        [Ignore]
        [ForeignKey("WardId")]
        public Ward WardFk { get; set; }

        /// <summary>
        /// Lãnh đạo
        /// </summary>
        public Guid? DirectorId { get; set; }

        [Ignore]
        [ForeignKey("DirectorId")]
        public virtual DIEmployee DirectorFk { get; set; }
    }
}
