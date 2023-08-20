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

        [MaxLength(500)]
        public virtual string Description { get; set; }

        public virtual bool Inactive { get; set; }

        [Ignore]
        [ForeignKey(nameof(PatientId))]
        public virtual Patient PatientFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(GenderId))]
        public virtual SGender SGenderFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(EthnicityId))]
        public virtual SEthnic SEthnicFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(CareerId))]
        public virtual SCareer SCareerFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(CountryId))]
        public virtual SCountry SCountryFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(ProvinceId))]
        public virtual SProvince SProvinceFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(DistrictId))]
        public virtual SDistrict SDistrictFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(WardId))]
        public virtual SWard SWardFk { get; set; }
    }
}
