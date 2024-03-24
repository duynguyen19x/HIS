using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Dictionary
{
    /// <summary>
    /// Khoa.
    /// </summary>
    [Table("DIDepartment")]
    public class Department : AuditedEntity<Guid>
    {
        /// <summary>
        /// Mã khoa
        /// </summary>
        [Required]
        [MaxLength(50)]
        public virtual string Code { get; set; }

        /// <summary>
        /// Tên khoa
        /// </summary>
        [Required]
        [MaxLength(255)]
        public virtual string Name { get; set; }

        /// <summary>
        /// Mã khoa (BYT)
        /// </summary>
        [MaxLength(50)]
        public virtual string MediCode { get; set; }

        /// <summary>
        /// Loại khoa
        /// </summary>
        [Required]
        public virtual int DepartmentTypeId { get; set; }

        /// <summary>
        /// Thuộc chi nhánh
        /// </summary>
        public virtual Guid BranchId { get; set; }

        /// <summary>
        /// Trưởng khoa
        /// </summary>
        public virtual Guid? ChiefId { get; set; }

        /// <summary>
        /// Điện thoại
        /// </summary>
        [MaxLength(50)]
        public virtual string Tel { get; set; }

        /// <summary>
        /// Địa chỉ
        /// </summary>
        [MaxLength(50)]
        public virtual string Email { get; set; }

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
        [ForeignKey("DepartmentTypeId")]
        public virtual DepartmentType DepartmentTypeFk { get; set; }

        [Ignore]
        [ForeignKey("BranchId")]
        public virtual Branch BranchFk { get; set; }

        [Ignore]
        [ForeignKey("ChiefId")]
        public virtual Employee ChiefFk { get; set; }
    }
}
