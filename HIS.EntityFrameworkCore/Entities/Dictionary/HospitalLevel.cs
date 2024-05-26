using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Constants;
using HIS.EntityFrameworkCore.Constants.Dictionary;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Hạng bệnh viện
    /// </summary>
    [Table("SHospitalLevel")]
    public class HospitalLevel : AuditedEntity<Guid>
    {
        [Required]
        [StringLength(HospitalLevelConst.MaxHospitalLevelCodeLength, MinimumLength = HospitalLevelConst.MinHospitalLevelCodeLength)]
        public string HospitalLevelCode { get; set; }

        [Required]
        [StringLength(HospitalLevelConst.MaxHospitalLevelNameLength, MinimumLength = HospitalLevelConst.MinHospitalLevelNameLength)]
        public string HospitalLevelName { get; set; }

        [StringLength(HospitalLevelConst.MaxDescriptionLength, MinimumLength = HospitalLevelConst.MinDescriptionLength)]
        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }

    }
}
