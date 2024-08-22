using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin bệnh án
    /// </summary>
    [Table("DPatientRecords")]
    public class PatientRecord : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// Mã bệnh án
        /// </summary>
        [MaxLength(50)]
        [Required]
        public virtual string Code { get; set; }

        /// <summary>
        /// Tên bệnh nhân
        /// </summary>
        [MaxLength(255)]
        [Required]
        public virtual string Name { get; set; }

        public virtual Guid PatientId { get; set; }

        /// <summary>
        /// Loại bệnh án
        /// </summary>
        public virtual int PatientRecordTypeId { get; set; }

        /// <summary>
        /// Trạng thái bệnh án
        /// </summary>
        public virtual int PatientRecordStatusId { get; set; }

        /// <summary>
        /// Ngày tạo bệnh án
        /// </summary>
        public virtual int PatientRecordDate { get; set; }

        /// <summary>
        /// Chi nhánh đăng ký
        /// </summary>
        public virtual Guid BranchId { get; set; }

        /// <summary>
        /// Khoa đăng ký
        /// </summary>
        public virtual Guid DepartmentId { get; set; }

        /// <summary>
        /// Phòng đăng ký
        /// </summary>
        public virtual Guid RoomId { get; set; }

        [MaxLength(255)]
        public virtual string Description { get; set; }

        public virtual DateTime? BirthDate { get; set; }

        [Required]
        public virtual int BirthYear { get; set; }

        [MaxLength(255)]
        public virtual string BirthPlace { get; set; }

        /// <summary>
        /// Giới tính
        /// </summary>
        public virtual Guid? GenderId { get; set; }

        /// <summary>
        /// Dân tộc
        /// </summary>
        public virtual Guid? EthnicId { get; set; }

        /// <summary>
        /// Tôn giáo
        /// </summary>
        public virtual Guid? ReligionId { get; set; }

        /// <summary>
        /// Quốc tịch
        /// </summary>
        public virtual Guid? CountryId { get; set; }

        /// <summary>
        /// Tỉnh, thành phố
        /// </summary>
        public virtual Guid? ProvinceId { get; set; }

        /// <summary>
        /// Quận, huyện
        /// </summary>
        public virtual Guid? DistrictId { get; set; }

        /// <summary>
        /// Xã, phường
        /// </summary>
        public virtual Guid? WardId { get; set; }

        [MaxLength(255)]
        public virtual string Address { get; set; }

        /// <summary>
        /// Nghề nghiệp
        /// </summary>
        public virtual Guid? CareerId { get; set; }

        [MaxLength(255)]
        public virtual string WorkPlace { get; set; }

        /// <summary>
        /// Nhóm máu ABO
        /// </summary>
        public virtual Guid? BloodTypeId { get; set; }

        /// <summary>
        /// Nhóm máu Rh
        /// </summary>
        public virtual Guid? BloodTypeRhId { get; set; }

        /// <summary>
        /// Số CMND, CCCD
        /// </summary>
        [MaxLength(255)]
        public virtual string IdentificationNumber { get; set; }

        /// <summary>
        /// Ngày cấp
        /// </summary>
        public virtual DateTime? IssueDate { get; set; }

        /// <summary>
        /// Nơi cấp
        /// </summary>
        [MaxLength(255)]
        public virtual string IssueBy { get; set; }

        /// <summary>
        /// Số điện thoại cố định
        /// </summary>
        [MaxLength(50)]
        public virtual string Tel { get; set; }

        /// <summary>
        /// Số điện thoại di động
        /// </summary>
        [MaxLength(50)]
        public virtual string Mobile { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [MaxLength(50)]
        public virtual string Email { get; set; }

        /// <summary>
        /// Tên người liên hệ
        /// </summary>
        [MaxLength(255)]
        public virtual string ContactName { get; set; }

        /// <summary>
        /// Quan hệ của người liên hệ với bệnh nhân 
        /// </summary>
        [MaxLength(50)]
        public virtual string ContactType { get; set; }

        [MaxLength(50)]
        public virtual string ContactAddress { get; set; }

        [MaxLength(50)]
        public virtual string ContactTel { get; set; }

        [MaxLength(50)]
        public virtual string ContactMobile { get; set; }

        [MaxLength(50)]
        public virtual string ContactIdentificationNumber { get; set; }

        public virtual DateTime? ContactIssueDate { get; set; }

        [MaxLength(255)]
        public virtual string ContactIssueBy { get; set; }

        #region - tiếp đón

        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime ReceptionDate { get; set; }

        /// <summary>
        /// Đối tượng bệnh nhân
        /// </summary>
        public virtual int PatientObjectTypeId { get; set; }

        /// <summary>
        /// Ưu tiên
        /// </summary>
        public virtual bool IsPriority { get; set; }

        /// <summary>
        /// Lý do khám
        /// </summary>
        [MaxLength(512)]
        public virtual string HospitalizationReason { get; set; }

        /// <summary>
        /// Bệnh nhân chuyển viện đến
        /// </summary>
        public virtual bool IsTransferIn { get; set; }

        /// <summary>
        /// Số chuyển viện
        /// </summary>
        [MaxLength (50)] 
        public virtual string TransferInCode { get; set; }

        /// <summary>
        /// Mã KCBBĐ nơi chuyển đến
        /// </summary>
        [MaxLength(50)]
        public virtual string TransferInMediOrgCode { get; set; }

        /// <summary>
        /// Tên nơi chuyển đến
        /// </summary>
        [MaxLength(255)]
        public virtual string TransferInMediOrgName { get; set; }

        /// <summary>
        /// Khám, điều trị tại nơi chuyển đến từ ngày
        /// </summary>
        public virtual DateTime? TransferInTimeFrom { get; set; }

        /// <summary>
        /// Khám, điều trị tại nơi chuyển đến tới ngày
        /// </summary>
        public virtual DateTime? TransferInTimeTo { get; set; }

        /// <summary>
        /// Mã chẩn đoán của nơi chuyển đến
        /// </summary>
        [MaxLength(50)]
        public virtual string TransferInIcdCode { get; set; }

        /// <summary>
        /// Chẩn đoán của nơi chuyển đến
        /// </summary>
        [MaxLength(255)]
        public virtual string TransferInIcdName { get; set; }

        /// <summary>
        /// Hình thức chuyển viện đến
        /// </summary>
        public virtual Guid? TransferInFormId { get; set; }

        /// <summary>
        /// Lý do chuyển viện
        /// </summary>
        public virtual Guid? TransferInReasonId { get; set; } 

        /// <summary>
        /// Chuyển đúng tuyến CMKT
        /// 1: đúng tuyến
        /// 0: vượt tuyến
        /// </summary>
        public virtual bool? TransferInRightRoute { get; set; } 

        #endregion

        #region - thanh toán

        #endregion

        [ForeignKey("GenderId")]
        public virtual Gender GenderFk { get; set; }

        [ForeignKey("EthnicId")]
        public virtual Ethnicity EthnicFk { get; set; }

        [ForeignKey("ReligionId")]
        public virtual Religion ReligionFk { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country CountryFk { get; set; }

        [ForeignKey("ProvinceId")]
        public virtual Province ProvinceFk { get; set; }

        [ForeignKey("DistrictId")]
        public virtual District DistrictFk { get; set; }

        [ForeignKey("WardId")]
        public virtual Ward WardFk { get; set; }

        [ForeignKey("CareerId")]
        public virtual Career CareerFk { get; set; }

        [ForeignKey("BloodTypeId")]
        public virtual BloodType BloodTypeFk { get; set; }

        [ForeignKey("BloodTypeRhId")]
        public virtual BloodRhType BloodTypeRhFk { get; set; }
    }
}
