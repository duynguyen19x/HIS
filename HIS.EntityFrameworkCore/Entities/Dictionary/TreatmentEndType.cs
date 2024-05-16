using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Hình thức xử trí.
    /// </summary>
    [Table("STreatmentEndType")]
    public class TreatmentEndType : AuditedEntity<int>
    {
        [MaxLength(50)]
        public virtual string Code { get; set; }

        [MaxLength(255)]
        [Required]
        public virtual string Name { get; set; }

        /// <summary>
        /// Dùng cho bệnh nhân khám bệnh và điều trị ngoại trú
        /// </summary>
        public virtual bool IsForOutPatient { get; set; }

        /// <summary>
        /// Dùng cho bệnh nhân điều trị nội trú
        /// </summary>
        public virtual bool IsForInPatient { get; set; } 

        [MaxLength(255)]
        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }

        public virtual bool Inactive { get; set; }

    }
}
