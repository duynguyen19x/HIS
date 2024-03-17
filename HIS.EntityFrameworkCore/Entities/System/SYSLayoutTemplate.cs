using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.System
{
    /// <summary>
    /// Cấu hình cột.
    /// </summary>
    [Table("SYSLayoutTemplate")]
    public class SYSLayoutTemplate : AuditedEntity<Guid>
    {
        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Loại mẫu (0 là cấu hình cột, các trường hợp khác bổ sung sau)
        /// </summary>
        [Required]
        public int TemplateType { get; set; }

        [Required]
        public string TemplateValue { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Chia sẻ mẫu tùy chỉnh của người dùng cho những người dùng khác.
        /// </summary>
        public bool IsPublic { get; set; }

        /// <summary>
        /// Mẫu tùy chỉnh của người dùng.
        /// </summary>
        public Guid? UserId { get; set; }

        [ForeignKey("UserId")]
        [Ignore]
        public SYSUser UserFk { get; set; }
    }
}