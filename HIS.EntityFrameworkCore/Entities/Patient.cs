using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Thông tin bệnh nhân
    /// </summary>
    [Table("DPatients")]
    public class Patient : FullAuditedEntity<Guid>
    {
        [MaxLength(EntityConst.Length50)]
        public string PatientCode { get; set; }

        [MaxLength(EntityConst.Length512)]
        public string PatientName { get; set; }

        public DateTime? BirthDate { get; set; }

        public int BirthYear { get; set; }

        [MaxLength(EntityConst.Length512)]
        public string BirthPlace { get; set; }

        public Guid BranchId { get; set; } // chi nhánh làm việc

        public Guid? PatientNumberId { get; set; } // mã số thứ tự bệnh nhân

        public Guid? BloodTypeId { get; set; }

        public Guid? BloodRhTypeId { get; set; }

        public int? GenderId { get; set; }

        public Guid? CareerId { get; set; }

        public Guid? EthnicityId { get; set; }

        public Guid? ReligionId { get; set; }

        public Guid? CountryId { get; set; }

        public Guid? ProvinceId { get; set; }

        public Guid? DistrictId { get; set; }

        public Guid? WardId { get; set; }

        [MaxLength(EntityConst.Length512)]
        public string Address { get; set; }

        [MaxLength(EntityConst.Length50)]
        public string PhoneNumber { get; set; }

        [MaxLength(EntityConst.Length128)]
        public string Email { get; set; }

        [MaxLength(EntityConst.Length512)]
        public string WorkPlace { get; set; }

        [MaxLength(EntityConst.Length50)]
        public string IdentificationNumber { get; set; } // số cmnd, cccd của bệnh nhân

        [MaxLength(EntityConst.Length512)]
        public string IssueBy { get; set; } // nơi cấp cmnd, cccd

        public DateTime? IssueDate { get; set; } // ngày cấp cmnd, cccd

        [MaxLength(EntityConst.Length128)]
        public string ContactName { get; set; } // người liên hệ

        [MaxLength(EntityConst.Length512)]
        public string ContactRelationshipName { get; set; } // tên mối quan hệ của người liên hệ và bệnh nhân

        [MaxLength(EntityConst.Length50)]
        public string ContactIdentificationNumber { get; set; } // số cmnd, cccd của người liên hệ

        [MaxLength(EntityConst.Length512)]
        public string ContactIssueBy { get; set; }

        public DateTime? ContactIssueDate { get; set; }

        [MaxLength(EntityConst.Length50)]
        public string ContactPhoneNumber { get; set; } // số điện thoại của người liên hệ

        [MaxLength(EntityConst.Length512)]
        public string ContactAddress { get; set; } // địa chỉ của người liên hệ

        [MaxLength(EntityConst.Length512)]
        public string Description { get; set; } // ghi chú
    }
}
