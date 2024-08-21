using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Thời gian tử vong.
    /// </summary>
    [Table("SDeathWithins")]
    public class DeathWithin : AuditedEntity<Guid>
    {
        [Required]
        [MaxLength(50)]
        public virtual string Code { get; set; }

        [Required]
        [MaxLength(255)]
        public virtual string Name { get; set; }

        [MaxLength(255)]
        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }

        public virtual bool Inactive { get; set; }

    }
}
