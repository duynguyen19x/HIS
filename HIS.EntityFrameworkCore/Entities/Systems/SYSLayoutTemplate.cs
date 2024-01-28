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
        [MaxLength(50)]
        public string LayoutTemplateCode { get; set; }

        [MaxLength(255)]
        public string LayoutTemplateName { get; set; }

        public int RefTypeId { get; set; }

        public string TemplateConfig { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public Guid? UserId { get; set; }

        public bool IsPublic { get; set; }

        [ForeignKey("RefTypeId")]
        public SYSRefType RefTypeFk { get; set; }

        [ForeignKey("UserId")]
        public User UserFk { get; set; }
    }
}