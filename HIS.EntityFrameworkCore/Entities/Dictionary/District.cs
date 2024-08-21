using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Quận, huyện
    /// </summary>
    [Table("SDistricts")]
    public class District : AuditedEntity<Guid>
    {
        [Required]
        [MaxLength(50)]
        public string DistrictCode { get; set; }

        [Required]
        [MaxLength(255)]
        public string DistrictName { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public bool Inactive { get; set; }

        public Guid ProvinceId { get; set; }

        [ForeignKey(nameof(ProvinceId))]
        public virtual Province ProvinceFk { get; set; }

        public District() { }
    }
}
