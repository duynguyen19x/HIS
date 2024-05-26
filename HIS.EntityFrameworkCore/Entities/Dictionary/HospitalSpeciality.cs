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
    /// Chuyên khoa
    /// </summary>
    [Table("SHospitalSpeciality")]
    public class HospitalSpeciality : AuditedEntity<Guid>
    {
        [Required]
        [StringLength(HospitalSpecialityConst.MaxHospitalSpecialityCodeLength, MinimumLength = HospitalSpecialityConst.MinHospitalSpecialityCodeLength)]
        public string HospitalSpecialityCode { get; set; }

        [Required]
        [StringLength(HospitalSpecialityConst.MaxHospitalSpecialityNameLength, MinimumLength = HospitalSpecialityConst.MinHospitalSpecialityNameLength)]
        public string HospitalSpecialityName { get; set; }

        [StringLength(HospitalSpecialityConst.MaxDescriptionLength, MinimumLength = HospitalSpecialityConst.MinDescriptionLength)]
        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }
        
    }
}
