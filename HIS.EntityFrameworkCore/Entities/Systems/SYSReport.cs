using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    /// <summary>
    /// Báo cáo.
    /// </summary>
    [Table("SYSReport")]
    public class SYSReport : AuditedEntity<int>
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }

        public int ReportCategoryId { get; set; }

        [ForeignKey("ReportCategoryId")]
        public SYSReportCategory ReportCategoryFk { get; set; }
    }
}
