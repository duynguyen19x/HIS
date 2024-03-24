using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Dictionary
{
    /// <summary>
    /// Chi nhánh.
    /// </summary>
    [Table("DIBranch")]
    public class Branch : AuditedEntity<Guid>
    {
        /// <summary>
        /// Mã chi nhánh
        /// </summary>
        [Required]
        [MaxLength(50)]
        public virtual string Code { get; set; }

        /// <summary>
        /// Tên chi nhánh
        /// </summary>
        [Required]
        [MaxLength(255)]
        public virtual string Name { get; set; }

        /// <summary>
        /// Mã khám chữa bệnh ban đầu
        /// </summary>
        [MaxLength(255)]
        public virtual string MediOrgCode { get; set; }

        /// <summary>
        /// Mã KCBBĐ đúng tuyến (ngăn cách bởi dấu ;)
        /// </summary>
        [MaxLength(4000)]
        public virtual string MediOrgAcceptCode { get; set; }

        /// <summary>
        /// Hạng bệnh viện (hạng I, II, III và đặc biệt)
        /// </summary>
        [MaxLength(50)]
        public virtual string Level { get; set; }

        /// <summary>
        /// Chuyên khoa
        /// </summary>
        [MaxLength(50)]
        public virtual string Specialty { get; set; }

        /// <summary>
        /// Tuyến bệnh viện
        /// </summary>
        [MaxLength(50)]
        public virtual string Line { get; set; }

        /// <summary>
        /// Tên đơn vị quản lý (sở y tế/bộ y tế)
        /// </summary>
        [MaxLength(50)]
        public virtual string ParentOrganizationName { get; set; }

        /// <summary>
        /// Điện thoại
        /// </summary>
        [MaxLength(50)]
        public virtual string Tel { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [MaxLength(50)]
        public virtual string Email { get; set; }

        /// <summary>
        /// Địa chỉ (số nhà, thôn, xóm)
        /// </summary>
        [MaxLength(255)]
        public virtual string Address { get; set; }

        /// <summary>
        /// Tỉnh, thành phố
        /// </summary>
        public virtual Guid? ProvinceId { get; set; }

        /// <summary>
        /// Quận, huyện
        /// </summary>
        public virtual Guid? DistrictId { get; set; }

        /// <summary>
        /// Xã, phường
        /// </summary>
        public virtual Guid? WardId { get; set; }

        /// <summary>
        /// Lãnh đạo
        /// </summary>
        public virtual Guid? DirectorId { get; set; }

        /// <summary>
        /// Ghi chú
        /// </summary>
        [MaxLength(255)]
        public virtual string Description { get; set; }

        /// <summary>
        /// Số thứ tự hiển thị
        /// </summary>
        public virtual int SortOrder { get; set; }

        /// <summary>
        /// Khóa
        /// </summary>
        public virtual bool Inactive { get; set; }

        [Ignore]
        [ForeignKey("ProvinceId")]
        public virtual Province ProvinceFk { get; set; }

        [Ignore]
        [ForeignKey("DistrictId")]
        public virtual District DistrictFk { get; set; }

        [Ignore]
        [ForeignKey("WardId")]
        public virtual Ward WardFk { get; set; }

        [Ignore]
        [ForeignKey("DirectorId")]
        public virtual Employee DirectorFk { get; set; }
    }
}
