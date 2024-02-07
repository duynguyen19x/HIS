using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    /// <summary>
    /// Chức năng.
    /// </summary>
    [Table("SYSRefType")]
    public class SYSRefType : AuditedEntity<int>
    {
        [MaxLength(255)]
        [Required]
        public string Name { get; set; }

        public int? RefTypeCategoryId { get; set; }

        public int? ParentId { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int SortOrder { get; set; }

        [Ignore]
        [ForeignKey("RefTypeCategoryId")]
        public SYSRefTypeCategory RefTypeCategoryFk { get; set; }
    }
}
