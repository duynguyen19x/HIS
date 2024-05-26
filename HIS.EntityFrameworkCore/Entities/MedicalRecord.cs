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
    public class MedicalRecord : FullAuditedEntity<Guid>
    {
        public Guid PatientId { get; set; }
        public string MedicalRecordCode { get; set; }
        public DateTime MedicalRecordDate { get; set; }
        public int MedicalRecordTypeId { get; set; }
        public int MedicalRecordStatusId { get; set; }
        
        public Guid BranchId { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid RoomId { get; set; }
        public Guid UserId { get; set; }

        public string PatientCode { get; set; }
        public string PatientName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int BirthYear { get; set; }
        public string BirthPlace { get; set; }
        public Guid? BloodTypeId { get; set; }
        public Guid? BloodRhTypeId { get; set; }
        public Guid? GenderId { get; set; }
        public Guid? CareerId { get; set; }
        public Guid? EthnicityId { get; set; }
        public Guid? ReligionId { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? ProvinceId { get; set; }
        public Guid? WardId { get; set; }
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
        public int PatientObjectTypeId { get; set; }
        public int ReceptionObjectTypeId { get; set; }
        public bool IsPriority { get; set; }
        public bool IsTransferIn { get; set; }
        public string TransferInCode { get; set; }
        public string TransferInMediOrgCode { get; set; }
        public string TransferInMediOrgName { get; set; }
        public DateTime? TransferInTimeFrom { get; set; }
        public DateTime? TransferInTimeTo { get; set; }
        public string TransferInIcdCode { get; set; }
        public string TransferInIcdName { get; set; }
        public Guid? TransferInFormId { get; set; }
        public Guid? TransferInReasonId { get; set; }
        public bool? IsTransferInRightRoute { get; set; } // chuyển bệnh nhân đúng tuyến CMKT

        public string HospitalizationReason { get; set; } // lý do nhập viện

        public int NumOrder { get; set; } // só thứ tự
        public string Description { get; set; }
    }
}
