using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Business.PatientRecords.Dto
{
    public class PatientRecordDto : EntityDto<Guid?>
    {
        /// <summary>
        /// Mã bệnh án
        /// </summary>
        public virtual string Code { get; set; }

        /// <summary>
        /// Tên bệnh nhân
        /// </summary>
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

        public virtual string BranchName { get; set; }

        /// <summary>
        /// Khoa đăng ký
        /// </summary>
        public virtual Guid DepartmentId { get; set; }

        public virtual string DepartmentName { get; set; }

        /// <summary>
        /// Phòng đăng ký
        /// </summary>
        public virtual Guid RoomId { get; set; }

        public virtual string RoomName { get; set; }

        public virtual string Description { get; set; }

        public virtual DateTime? BirthDate { get; set; }

        public virtual int BirthYear { get; set; }

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

        public virtual string Address { get; set; }

        /// <summary>
        /// Nghề nghiệp
        /// </summary>
        public virtual Guid? CareerId { get; set; }

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
        public virtual string IdentificationNumber { get; set; }

        /// <summary>
        /// Ngày cấp
        /// </summary>
        public virtual DateTime? IssueDate { get; set; }

        /// <summary>
        /// Nơi cấp
        /// </summary>
        public virtual string IssueBy { get; set; }

        /// <summary>
        /// Số điện thoại cố định
        /// </summary>
        public virtual string Tel { get; set; }

        /// <summary>
        /// Số điện thoại di động
        /// </summary>
        public virtual string Mobile { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public virtual string Email { get; set; }

        /// <summary>
        /// Tên người liên hệ
        /// </summary>
        public virtual string ContactName { get; set; }

        /// <summary>
        /// Quan hệ của người liên hệ với bệnh nhân 
        /// </summary>
        public virtual string ContactType { get; set; }

        public virtual string ContactAddress { get; set; }

        public virtual string ContactTel { get; set; }

        public virtual string ContactMobile { get; set; }

        public virtual string ContactIdentificationNumber { get; set; }

        public virtual DateTime? ContactIssueDate { get; set; }

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
        public virtual string HospitalizationReason { get; set; }

        /// <summary>
        /// Bệnh nhân chuyển viện đến
        /// </summary>
        public virtual bool IsTransferIn { get; set; }

        /// <summary>
        /// Số chuyển viện
        /// </summary>
        public virtual string TransferInCode { get; set; }

        /// <summary>
        /// Mã KCBBĐ nơi chuyển đến
        /// </summary>
        public virtual string TransferInMediOrgCode { get; set; }

        /// <summary>
        /// Tên nơi chuyển đến
        /// </summary>
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
        public virtual string TransferInIcdCode { get; set; }

        /// <summary>
        /// Chẩn đoán của nơi chuyển đến
        /// </summary>
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

    }
}
