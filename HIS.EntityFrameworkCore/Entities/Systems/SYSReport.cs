using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    /// <summary>
    /// Báo cáo.
    /// </summary>
    [Table("SYSReport")]
    public class SYSReport : AuditedEntity<string>
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public string ParentID { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }

        public int ReportCategoryID { get; set; }

        [ForeignKey("ReportCategoryID")]
        public SYSReportCategory ReportCategoryFk { get; set; }
    }
}
