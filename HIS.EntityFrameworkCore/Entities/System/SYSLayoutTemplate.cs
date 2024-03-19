using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.System
{
    /// <summary>
    /// Cấu hình mẫu hiển thị.
    /// </summary>
    [Table("SYSLayoutTemplate")]
    public class SYSLayoutTemplate : AuditedEntity<Guid>
    {
        /// <summary>
        /// Mẫu tùy chỉnh của người dùng.
        /// </summary>
        public Guid? UserId { get; set; }

        [MaxLength(255)]
        public string SubSystemId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Loại mẫu (0 là cấu hình cột, các trường hợp khác bổ sung sau)
        /// </summary>
        [Required]
        public int TemplateType { get; set; }

        /// <summary>
        /// Giá trị (lưu chuỗi json)
        /// </summary>
        [Required]
        public string TemplateValue { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Là cấu hình mẫu hiển thị của hệ thống (người dùng không được phép chỉnh sửa)
        /// </summary>
        public bool IsDefault { get; set; } 

        /// <summary>
        /// Chia sẻ mẫu tùy chỉnh của người dùng cho những người dùng khác.
        /// </summary>
        public bool IsPublic { get; set; }


        [ForeignKey(nameof(SubSystemId))]
        public virtual SYSSubSystem SubSystemFk { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual SYSUser UserFk { get; set; }

    }
}