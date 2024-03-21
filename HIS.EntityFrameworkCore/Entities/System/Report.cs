using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.System
{
    /// <summary>
    /// Báo cáo.
    /// </summary>
    [Table("SYSReport")]
    public class Report : AuditedEntity<string>
    {
        [MaxLength(255)]
        public override string Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [MaxLength(255)]
        public string ParentId { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }

        public int ReportCategoryId { get; set; }

        [ForeignKey(nameof(ReportCategoryId))]
        public virtual ReportCategory ReportCategoryFk { get; set; }
    }
}
