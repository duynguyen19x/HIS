using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.System
{
    /// <summary>
    /// Nhóm báo cáo.
    /// </summary>
    [Table("SYSReportCategory")]
    public class SYSReportCategory : AuditedEntity<int>
    {
        [Required]
        [MaxLength(255)]
        public virtual string Name { get; set; }

        [MaxLength(255)]
        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }
    }
}
