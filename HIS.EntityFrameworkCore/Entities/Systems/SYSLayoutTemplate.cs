using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    /// <summary>
    /// Cấu hình cột.
    /// </summary>
    [Table("SYSLayoutTemplate")]
    public class SYSLayoutTemplate : AuditedEntity<Guid>
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public string TemplateValue { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Chia sẻ mẫu cho những người dùng khác.
        /// </summary>
        public bool IsPublic { get; set; }

        /// <summary>
        /// Người tạo mẫu.
        /// </summary>
        public Guid? UserID { get; set; }

        [ForeignKey("UserID")]
        public SYSUser UserFk { get; set; }
    }
}