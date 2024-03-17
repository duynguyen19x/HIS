using AutoMapper.Configuration.Annotations;
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
        [MaxLength(100)]
        [Required]
        public override string Id { get; set; }

        [MaxLength(255)]
        [Required]
        public virtual string Name { get; set; }

        [MaxLength(255)]
        public virtual string Description { get; set; }

        [MaxLength(100)]
        public virtual string ParentId { get; set; }

        public virtual int SortOrder { get; set; }

        public virtual bool Inactive { get; set; }

        public virtual int ReportCategoryId { get; set; }

        [ForeignKey(nameof(ReportCategoryId))]
        [Ignore]
        public virtual SYSReportCategory ReportCategoryFk { get; set; }
    }
}
