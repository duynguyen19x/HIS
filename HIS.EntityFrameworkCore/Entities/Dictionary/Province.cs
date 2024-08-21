using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Tỉnh, thành phố.
    /// </summary>
    [Table("SProvinces")]
    public class Province : AuditedEntity<Guid>
    {
        [Required]
        [MaxLength(50)]
        public string ProvinceCode { get; set; }

        [Required]
        [MaxLength(255)]
        public string ProvinceName { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public bool Inactive { get; set; }
    }
}
