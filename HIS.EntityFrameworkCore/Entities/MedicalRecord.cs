using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Hồ sơ bệnh án
    /// </summary>
    public class MedicalRecord : AuditedEntity<Guid>
    {
        [StringLength(MedicalRecordConst.MaxMedicalRecordCodeLength, MinimumLength = MedicalRecordConst.MinMedicalRecordCodeLength)]
        public string MedicalRecordCode { get; set; }
        public DateTime MedicalRecordDate { get; set; }
        public int MedicalRecordTypeID { get; set; }
        public int MedicalRecordStatusID { get; set; }
        [StringLength(MedicalRecordConst.MaxDescriptionLength, MinimumLength = MedicalRecordConst.MinDescriptionLength)]
        public string Description { get; set; }

        public DateTime ReceptionDate { get; set; } // thời gian tiếp đón
        public DateTime ClinicalDate { get; set; } // thời gian bắt đầu khám bệnh 
        public DateTime InDate { get; set; } // thời gian tiếp nhận nhập viện
        public DateTime DischargeDate { get; set; } // thời gian ra viện

        public Guid TreatmentID_Clinical { get; set; }
        public Guid TreatmentID_In { get; set; }
        public Guid TreatmentID_Discharge { get; set; }






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
    }
}
