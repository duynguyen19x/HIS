using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Xã, phường.
    /// </summary>
    [Table("SWard")]
    public class Ward : AuditedEntity<Guid>
    {
        [Required]
        [MaxLength(50)]
        public string WardCode { get; set; } 

        [Required]
        [MaxLength(255)]
        public string WardName { get; set; } 

        [MaxLength(50)]
        public string SearchCode { get; set; } // viết tắt (T/H/X)

        [MaxLength(255)]
        public string Description { get; set; } // ghi chú

        public bool Inactive { get; set; } // khóa

        public Guid DistrictId { get; set; }

        [ForeignKey(nameof(DistrictId))]
        public virtual District DistrictFk { get; set; }
    }
}
