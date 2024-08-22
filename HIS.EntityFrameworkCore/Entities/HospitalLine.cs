using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Tuyến bệnh viện
    /// </summary>
    [Table("SHospitalLines")]
    public class HospitalLine : AuditedEntity<Guid>
    {
        [Required]
        [StringLength(HospitalLineConst.MaxHospitalLineCodeLength, MinimumLength = HospitalLineConst.MinHospitalLineCodeLength)]
        public string HospitalLineCode { get; set; }

        [Required]
        [StringLength(HospitalLineConst.MaxHospitalLineNameLength, MinimumLength = HospitalLineConst.MinHospitalLineNameLength)]
        public string HospitalLineName { get; set; }

        [StringLength(HospitalLineConst.MaxDescriptionLength, MinimumLength = HospitalLineConst.MinDescriptionLength)]
        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }

        
    }
}
