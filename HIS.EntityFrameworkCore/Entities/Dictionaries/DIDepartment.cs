using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Khoa.
    /// </summary>
    [Table("DIDepartment")]
    public class DIDepartment : AuditedEntity<Guid>
    {
        /// <summary>
        /// Mã khoa
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        /// <summary>
        /// Tên khoa
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Mã khoa (BYT)
        /// </summary>
        [MaxLength(50)]
        public string MediCode { get; set; }

        /// <summary>
        /// Loại khoa
        /// </summary>
        public int DepartmentTypeId { get; set; }

        /// <summary>
        /// Thuộc chi nhánh
        /// </summary>
        public Guid BranchId { get; set; }

        /// <summary>
        /// Trưởng khoa
        /// </summary>
        public Guid? ChiefId { get; set; }

        /// <summary>
        /// Điện thoại
        /// </summary>
        [MaxLength(50)]
        public string Tel { get; set; }

        /// <summary>
        /// Địa chỉ
        /// </summary>
        [MaxLength(50)]
        public string Email { get; set; }

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

        [Ignore]
        [ForeignKey("DepartmentTypeId")]
        public virtual DepartmentType DepartmentTypeFk { get; set; }

        [Ignore]
        [ForeignKey("BranchId")]
        public virtual DIBranch BranchFk { get; set; }

        [Ignore]
        [ForeignKey("ChiefId")]
        public virtual DIEmployee ChiefFk { get; set; }
    }
}
