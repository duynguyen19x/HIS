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
    /// Thông tin bệnh án
    /// </summary>
    public class MedicalRecord : FullAuditedEntity<Guid>
    {
        public Guid PatientId { get; set; }
        [MaxLength(EntityConst.Length50)]
        public string MedicalRecordCode { get; set; }
        public DateTime MedicalRecordDate { get; set; }
        public int MedicalRecordTypeId { get; set; }
        public int MedicalRecordStatusId { get; set; }
        
        public Guid BranchId { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid RoomId { get; set; }
        public Guid UserId { get; set; }

        [MaxLength(EntityConst.Length50)]
        public string PatientCode { get; set; }
        [MaxLength(EntityConst.Length512)]
        public string PatientName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int BirthYear { get; set; }
        [MaxLength(EntityConst.Length512)]
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

        [MaxLength(EntityConst.Length512)]
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

        public DateTime ReceptionDate { get; set; }
        [MaxLength(EntityConst.Length512)]
        public string ChiefComplaint { get; set; } // lý do đến khám
        public int PatientObjectTypeId { get; set; }
        public int ReceptionObjectTypeId { get; set; }
        public bool IsPriority { get; set; }
        public bool IsTransferIn { get; set; }
        [MaxLength(EntityConst.Length50)]
        public string TransferInCode { get; set; }
        [MaxLength(EntityConst.Length50)]
        public string TransferInMediOrgCode { get; set; }
        [MaxLength(EntityConst.Length512)]
        public string TransferInMediOrgName { get; set; }
        public DateTime? TransferInTimeFrom { get; set; }
        public DateTime? TransferInTimeTo { get; set; }
        [MaxLength(EntityConst.Length50)]
        public string TransferInIcdCode { get; set; }
        [MaxLength(EntityConst.Length512)]
        public string TransferInIcdName { get; set; }
        public Guid? TransferInFormId { get; set; }
        public Guid? TransferInReasonId { get; set; }
        public bool? IsTransferInRightRoute { get; set; } // chuyển bệnh nhân đúng tuyến CMKT

        [MaxLength(EntityConst.Length512)]
        public string HospitalizationReason { get; set; } // lý do nhập viện

        public int NumOrder { get; set; } // só thứ tự
        [MaxLength(EntityConst.Length512)]
        public string Description { get; set; }
    }
}
