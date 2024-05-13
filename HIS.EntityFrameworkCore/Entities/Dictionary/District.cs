using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Dictionary
{
    /// <summary>
    /// Quận, huyện
    /// </summary>
    [Table("DIDistrict")]
    public class District : AuditedEntity<Guid>
    {
        [Required]
        [MaxLength(50)]
        public virtual string Code { get; set; }

        [Required]
        [MaxLength(255)]
        public virtual string Name { get; set; }

        [MaxLength(255)]
        public virtual string Description { get; set; }

        public virtual bool Inactive { get; set; }

        public virtual Guid ProvinceId { get; set; }

        [ForeignKey("ProvinceId")]
        public Province ProvinceFk { get; set; }

        public District() { }
    }
}
