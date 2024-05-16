using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Thông tin bệnh án
    /// </summary>
    public class MedicalRecord : AuditedEntity<Guid>
    {
        public Guid PatientID { get; set; }
        public string MedicalRecordCode { get; set; }
        public DateTime MedicalRecordDate { get; set; }
        public int MedicalRecordTypeID { get; set; }
        public int MedicalRecordStatusID { get; set; }
        public Guid BranchID { get; set; }
        public Guid DepartmentID { get; set; }
        public Guid RoomID { get; set; }
        public Guid UserID { get; set; }

        public string PatientCode { get; set; }
        public string PatientName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int BirthYear { get; set; }
        public string BirthPlace { get; set; }
        public Guid? BloodTypeID { get; set; }
        public Guid? BloodRhTypeID { get; set; }
        public Guid? GenderID { get; set; }
        public Guid? CareerID { get; set; }
        public Guid? EthnicityID { get; set; }
        public Guid? ReligionID { get; set; }
        public Guid? CountryID { get; set; }
        public Guid? ProvinceID { get; set; }
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

        public DateTime ReceptionDate { get; set; }
        public string ChiefComplaint { get; set; } // lý do đến khám
        public int PatientObjectTypeID { get; set; }
        public int ReceptionObjectTypeID { get; set; }
        public bool IsPriority { get; set; }
        public bool IsTransferIn { get; set; }
        public string TransferInCode { get; set; }
        public string TransferInMediOrgCode { get; set; }
        public string TransferInMediOrgName { get; set; }
        public DateTime? TransferInTimeFrom { get; set; }
        public DateTime? TransferInTimeTo { get; set; }
        public string TransferInIcdCode { get; set; }
        public string TransferInIcdName { get; set; }
        public Guid? TransferInFormID { get; set; }
        public Guid? TransferInReasonID { get; set; }
        public bool? IsTransferInRightRoute { get; set; } // chuyển bệnh nhân đúng tuyến CMKT

        public string HospitalizationReason { get; set; } // lý do nhập viện
        public string Description { get; set; }
        
    }
}
