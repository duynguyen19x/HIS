using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Thông tin bệnh nhân
    /// </summary>
    [Table("DPatient")]
    public class Patient : FullAuditedEntity<Guid>
    {
        public string PatientCode { get; set; }

        public string PatientName { get; set; }

        public DateTime? BirthDate { get; set; }

        public int BirthYear { get; set; }

        public string BirthPlace { get; set; }

        public Guid? PatientNumberID { get; set; } // mã số thứ tự bệnh nhân

        public Guid? BloodTypeID { get; set; }

        public Guid? BloodRhTypeID { get; set; }

        public Guid? GenderID { get; set; }

        public Guid? CareerID { get; set; }

        public Guid? EthnicityID { get; set; }

        public Guid? ReligionID { get; set; }

        public Guid? CountryID { get; set; }

        public Guid? ProvinceID { get; set; }

        public Guid? DistrictID { get; set; }

        public Guid? WardID { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string WorkPlace { get; set; }

        public string IdentificationNumber { get; set; } // số cmnd, cccd của bệnh nhân

        public string IssueBy { get; set; } // nơi cấp cmnd, cccd

        public DateTime? IssueDate { get; set; } // ngày cấp cmnd, cccd

        public string ContactName { get; set; } // người liên hệ

        public string ContactRelationshipName { get; set; } // tên mối quan hệ của người liên hệ và bệnh nhân

        public string ContactIdentificationNumber { get; set; } // số cmnd, cccd của người liên hệ

        public string ContactIssueBy { get; set; }

        public DateTime? ContactIssueDate { get; set; }

        public string ContactPhoneNumber { get; set; } // số điện thoại của người liên hệ

        public string ContactAddress { get; set; } // địa chỉ của người liên hệ

        public string Description { get; set; } // ghi chú

        
    }
}
