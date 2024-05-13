using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Constants;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Dictionary;
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
    /// Bệnh nhân
    /// </summary>
    [Table("Patient")]
    public class Patient : AuditedEntity<Guid>
    {
        [Required]
        [StringLength(PatientConst.MaxPatientCodeLength, MinimumLength = PatientConst.MinPatientCodeLength)]
        public string PatientCode { get; set; }

        [Required]
        [StringLength(PatientConst.MaxPatientNameLength, MinimumLength = PatientConst.MinPatientNameLength)]
        public string PatientName { get; set; }

        public DateTime? BirthDate { get; set; }

        public int BirthYear { get; set; }

        [StringLength(PatientConst.MaxBirthPlaceLength, MinimumLength = PatientConst.MinBirthPlaceLength)]
        public string BirthPlace { get; set; }

        public Guid? GenderID { get; set; }

        public Guid? BloodTypeID { get; set; }

        public Guid? BloodRhTypeID { get; set; }

        public Guid? CareerID { get; set; }

        [StringLength(PatientConst.MaxWorkPlaceLength, MinimumLength = PatientConst.MinWorkPlaceLength)]
        public string WorkPlace { get; set; }

        public Guid? EthnicityID { get; set; }

        public Guid? ReligionID { get; set; }

        public Guid? CountryID { get; set; }

        public Guid? ProvinceID { get; set; }

        public Guid? WardID { get; set; }

        [StringLength(PatientConst.MaxAddressLength, MinimumLength = PatientConst.MinAddressLength)]
        public string Address { get; set; }

        [StringLength(PatientConst.MaxPhoneNumberLength, MinimumLength = PatientConst.MinPhoneNumberLength)]
        public string PhoneNumber { get; set; }

        [StringLength(PatientConst.MaxEmailLength, MinimumLength = PatientConst.MinEmailLength)]
        public string Email { get; set; }

        [StringLength(PatientConst.MaxIdentificationNumberLength, MinimumLength = PatientConst.MinIdentificationNumberLength)]
        public string IdentificationNumber { get; set; }

        [StringLength(PatientConst.MaxIssueByLength, MinimumLength = PatientConst.MinIssueByLength)]
        public string IssueBy { get; set; }

        public DateTime? IssueDate { get; set; }

        [StringLength(PatientConst.MaxDescriptionLength, MinimumLength = PatientConst.MinDescriptionLength)]
        public string Description { get; set; }

        [ForeignKey(nameof(GenderID))]
        public virtual Gender GenderFK { get; set; }

        [ForeignKey(nameof(BloodTypeID))]
        public virtual BloodType BloodTypeFK { get; set; }

        [ForeignKey(nameof(BloodRhTypeID))]
        public virtual BloodTypeRh BloodTypeRhFK { get; set; }

        [ForeignKey(nameof(CareerID))]
        public virtual Career CareerFK { get; set; }

        [ForeignKey(nameof(EthnicityID))]
        public virtual Ethnicity EthnicityFK { get; set; }

        [ForeignKey(nameof(ReligionID))]
        public virtual Religion ReligionFK { get; set; }

        [ForeignKey(nameof(CountryID))]
        public virtual Country CountryFK { get; set; }

        [ForeignKey(nameof(ProvinceID))]
        public virtual Province ProvinceFK { get; set; }

        [ForeignKey(nameof(WardID))]
        public virtual Ward WardFK { get; set; }

    }
}
