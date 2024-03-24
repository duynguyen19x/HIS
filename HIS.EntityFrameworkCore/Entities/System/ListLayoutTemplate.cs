using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.System
{
    /// <summary>
    /// Cấu hình mẫu hiển thị.
    /// </summary>
    [Table("SYSListLayoutTemplate")]
    public class ListLayoutTemplate : AuditedEntity<Guid>
    {
        [MaxLength(255)]
        [Required]
        public virtual string Code { get; set; }

        [MaxLength(255)]
        [Required]
        public virtual string Name { get; set; }

        /// <summary>
        /// Loại mẫu (0 là cấu hình cột, các trường hợp khác bổ sung sau)
        /// </summary>
        [Required]
        public virtual int TemplateType { get; set; }

        /// <summary>
        /// Giá trị (lưu chuỗi json)
        /// </summary>
        [Required]
        public virtual string TemplateValue { get; set; }

        [MaxLength(255)]
        public virtual string Description { get; set; }

        /// <summary>
        /// Là cấu hình mẫu hiển thị của hệ thống (người dùng không được phép chỉnh sửa)
        /// </summary>
        public virtual bool IsDefault { get; set; }

        /// <summary>
        /// Chia sẻ mẫu tùy chỉnh của người dùng cho những người dùng khác.
        /// </summary>
        public virtual bool IsPublic { get; set; }

        /// <summary>
        /// Mẫu tùy chỉnh của người dùng.
        /// </summary>
        public virtual Guid? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User UserFk { get; set; }

    }
}