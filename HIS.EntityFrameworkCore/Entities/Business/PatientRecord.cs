using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin đợt điều trị của bệnh nhân.
    /// </summary>
    public class PatientRecord : FullAuditedEntity<Guid>
    {
        [Required]
        [MaxLength(50)]
        public virtual string Code { get; set; }

        [Required]
        public virtual Guid PatientId { get; set; }

        [Required]
        [MaxLength(500)]
        public virtual string PatientName { get; set; }

        public DateTime? BirthDate { get; set; }

        [Required]
        public int BirthYear { get; set; }

        [MaxLength(500)]
        public string BirthPlace { get; set; }

        [MaxLength(50)]
        public virtual string IdentificationNumber { get; set; } // số CMND / CCCD

        public virtual DateTime? IssueDate { get; set; } // ngày cấp

        [MaxLength(500)]
        public virtual string IssueBy { get; set; } // nơi cấp

        [Required]
        public virtual Guid GenderId { get; set; }

        [Required]
        public virtual Guid EthnicityId { get; set; }

        [Required]
        public virtual Guid CareerId { get; set; }

        [Required]
        public virtual Guid CountryId { get; set; }

        public virtual Guid? ProvinceId { get; set; }

        public virtual Guid? DistrictId { get; set; }

        public virtual Guid? WardId { get; set; }

        public virtual Guid BranchId { get; set; }

        [MaxLength(500)]
        public virtual string Address { get; set; }

        [MaxLength(50)]
        public virtual string Tel { get; set; }

        [MaxLength(50)]
        public virtual string Mobile { get; set; }

        [MaxLength(50)]
        public virtual string Fax { get; set; }

        [MaxLength(50)]
        public virtual string Email { get; set; }

        [Required]
        public virtual int PatientTypeId { get; set; }

        [Required]
        public virtual int PatientRecordTypeId { get; set; }

        [Required]
        public virtual DateTime ReceiptionDate { get; set; } // thơi gian đăng ký, tiếp nhận
        public virtual Guid ReceiptionRoomId { get; set; } // phòng tiếp đón
        public virtual Guid ReceiptionDepartmentId { get; set; } // khoa đón tiếp

        public virtual bool IsEmergency { get; set; } // cấp cứu
        public virtual string HospitalizationReason { get; set; } // lý do nhập viện

        public virtual DateTime? StartDate { get; set; } // thời gian bắt đầu khám/ điều trị
        public virtual Guid? StartRoomId { get; set; } // phòng bắt đầu khám / điều trị
        public virtual Guid? StartDepartmentId { get; set; } // khoa bắt đầu khám / điều trị

        public virtual DateTime? EndDate { get; set; } // thời gian kết thúc điều trị
        public virtual Guid? EndRoomId { get; set; } // phòng kết thúc điều trị
        public virtual Guid? EndDepartmentId { get; set; } // khoa kết thúc điều trị

        [MaxLength(500)]
        public virtual string Description { get; set; }

        public virtual bool Inactive { get; set; }

        [Ignore]
        [ForeignKey(nameof(PatientId))]
        public virtual Patient PatientFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(GenderId))]
        public virtual Gender SGenderFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(EthnicityId))]
        public virtual Ethnic SEthnicFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(CareerId))]
        public virtual Career SCareerFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(CountryId))]
        public virtual Country SCountryFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(ProvinceId))]
        public virtual Province SProvinceFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(DistrictId))]
        public virtual District SDistrictFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(WardId))]
        public virtual SWard SWardFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(BranchId))]
        public virtual Branch SBracnhFk { get; set; }
    }
}
