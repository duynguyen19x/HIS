using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
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
        [MaxLength(50)]
        public string Code { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

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
        public Guid? UserID { get; set; }

        [ForeignKey("UserID")]
        public SYSUser UserFk { get; set; }
    }
}