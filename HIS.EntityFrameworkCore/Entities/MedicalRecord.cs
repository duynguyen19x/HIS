using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Hồ sơ bệnh án
    /// </summary>
    [Table("DMedicalRecord")]
    public class MedicalRecord : AuditedEntity<Guid>
    {
        [StringLength(MedicalRecordConst.MaxMedicalRecordCodeLength, MinimumLength = MedicalRecordConst.MinMedicalRecordCodeLength)]
        public string MedicalRecordCode { get; set; }

        public DateTime MedicalRecordDate { get; set; }

        public int PatientObjectTypeID { get; set; }

        public Guid PatientID { get; set; }

        public Guid BranchID { get; set; }

        public Guid DepartmentID { get; set; }

        public Guid RoomID { get; set; }

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

        public Guid? ReligionID { get; set; }

        public Guid? EthnicityID { get; set; }

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

        [StringLength(PatientConst.MaxFatherNameLength, MinimumLength = PatientConst.MinFatherNameLength)]
        public string FatherName { get; set; }

        [StringLength(PatientConst.MaxFatherEducationLevelLength, MinimumLength = PatientConst.MinFatherEducationLevelLength)]
        public string FatherEducationLevel { get; set; }

        [StringLength(PatientConst.MaxFatherCareerLength, MinimumLength = PatientConst.MinFatherCareerLength)]
        public string FatherCareer { get; set; }

        [StringLength(PatientConst.MaxMotherNameLength, MinimumLength = PatientConst.MinFatherNameLength)]
        public string MotherName { get; set; }

        [StringLength(PatientConst.MaxMotherEducationLevelLength, MinimumLength = PatientConst.MinMotherEducationLevelLength)]
        public string MotherEducationLevel { get; set; }

        [StringLength(PatientConst.MaxMotherCareerLength, MinimumLength = PatientConst.MinMotherCareerLength)]
        public string MotherCareer { get; set; }

        public string ContactName { get; set; }

        public string ContactType { get; set; }

        [MaxLength(50)]
        public string ContactAddress { get; set; }

        [MaxLength(50)]
        public string ContactPhoneNumber { get; set; }

        [MaxLength(50)]
        public string ContactEmail { get; set; }

        [MaxLength(50)]
        public string ContactIdentificationNumber { get; set; }

        [MaxLength(255)]
        public string ContactIssueBy { get; set; }

        public DateTime? ContactIssueDate { get; set; }

        public bool IsTransferIn { get; set; } // bệnh nhân chuyển viện đến

        [MaxLength(50)]
        public string TransferInCode { get; set; } // số chuyển viện

        [MaxLength(50)]
        public string TransferInMediOrgCode { get; set; } // mã KCBBĐ nơi chuyển đến

        [MaxLength(255)]
        public string TransferInMediOrgName { get; set; } // tên nơi chuyển đến

        public DateTime? TransferInTimeFrom { get; set; } // khám, điều trị tại nơi chuyển đến từ ngày

        public DateTime? TransferInTimeTo { get; set; } // khám, điều trị tại nơi chuyển đến tới ngày

        [MaxLength(50)]
        public virtual string TransferInIcdCode { get; set; } // mã chẩn đoán của nơi chuyển đến

        [MaxLength(255)]
        public virtual string TransferInIcdName { get; set; } // chẩn đoán của nơi chuyển đến

        public virtual Guid? TransferInFormID { get; set; } // hình thức chuyển viện đến

        public virtual Guid? TransferInReasonID { get; set; } // lý do chuyển viện

        public virtual bool? TransferInRightRoute { get; set; } // chuyển đúng tuyến CMKT

        [MaxLength(512)]
        public virtual string HospitalizationReason { get; set; } // lý do nhập viện

        [StringLength(PatientConst.MaxDescriptionLength, MinimumLength = PatientConst.MinDescriptionLength)]
        public string Description { get; set; }


        [ForeignKey(nameof(GenderID))]
        public virtual Gender GenderFK { get; set; }

        [ForeignKey(nameof(BloodTypeID))]
        public virtual BloodType BloodTypeFK { get; set; }

        [ForeignKey(nameof(BloodRhTypeID))]
        public virtual BloodRhType BloodTypeRhFK { get; set; }

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
