using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Constants;
using HIS.EntityFrameworkCore.Entities.System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Chi nhánh.
    /// </summary>
    [Table("SBranchs")]
    public class Branch : AuditedEntity<Guid>
    {
        [Required]
        [StringLength(BranchConst.MaxBranchCodeLength, MinimumLength = BranchConst.MinBranchCodeLength)]
        public string BranchCode { get; set; }

        [Required]
        [StringLength(BranchConst.MaxBranchNameLength, MinimumLength = BranchConst.MinBranchNameLength)]
        public string BranchName { get; set; }

        /// <summary>
        /// Mã khám chữa bệnh ban đầu
        /// </summary>
        [StringLength(BranchConst.MaxMediOrgCodeLength, MinimumLength = BranchConst.MinMediOrgCodeLength)]
        public string MediOrgCode { get; set; }

        /// <summary>
        /// Mã KCBBĐ đúng tuyến (ngăn cách bởi dấu ;)
        /// </summary>
        [StringLength(BranchConst.MaxMediOrgAcceptCodeLength, MinimumLength = BranchConst.MinMediOrgAcceptCodeLength)]
        public string MediOrgAcceptCode { get; set; }

        /// <summary>
        /// Hạng bệnh viện (hạng I, II, III và đặc biệt)
        /// </summary>
        public Guid? HospitalLevelID { get; set; }

        /// <summary>
        /// Tuyến bệnh viện
        /// </summary>
        public Guid? HospitalLineID { get; set; }

        /// <summary>
        /// Chuyên khoa
        /// </summary>
        public Guid? HospitalSpecialityID { get; set; }

        /// <summary>
        /// Tên đơn vị quản lý (sở y tế/bộ y tế)
        /// </summary>
        [StringLength(BranchConst.MaxParentOrganizationNameLength, MinimumLength = BranchConst.MinParentOrganizationNameLength)]
        public string ParentOrganizationName { get; set; }

        /// <summary>
        /// Điện thoại
        /// </summary>
        [StringLength(BranchConst.MaxPhoneNumberLength, MinimumLength = BranchConst.MinPhoneNumberLength)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [StringLength(BranchConst.MaxEmailLength, MinimumLength = BranchConst.MinEmailLength)]
        public string Email { get; set; }

        /// <summary>
        /// Địa chỉ (số nhà, thôn, xóm)
        /// </summary>
        [StringLength(BranchConst.MaxAddressLength, MinimumLength = BranchConst.MinAddressLength)]
        public string Address { get; set; }

        /// <summary>
        /// Tỉnh, thành phố
        /// </summary>
        public Guid? ProvinceID { get; set; }

        /// <summary>
        /// Quận, huyện
        /// </summary>
        public Guid? DistrictID { get; set; }

        /// <summary>
        /// Xã, phường
        /// </summary>
        public Guid? WardID { get; set; }

        /// <summary>
        /// Lãnh đạo
        /// </summary>
        public Guid? DirectorID { get; set; }

        /// <summary>
        /// Ghi chú
        /// </summary>
        [StringLength(BranchConst.MaxDescriptionLength, MinimumLength = BranchConst.MinDescriptionLength)]
        public string Description { get; set; }

        /// <summary>
        /// Số thứ tự hiển thị
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// Khóa
        /// </summary>
        public bool Inactive { get; set; }


        [ForeignKey(nameof(HospitalLevelID))]
        public virtual HospitalLevel HospitalLevelFk { get; set; }

        [ForeignKey(nameof(HospitalLineID))]
        public virtual HospitalLine HospitalLineFk { get; set; }

        [ForeignKey(nameof(HospitalSpecialityID))]
        public virtual HospitalSpeciality HospitalSpecialityFk { get; set; }

        [ForeignKey(nameof(ProvinceID))]
        public virtual Province ProvinceFk { get; set; }

        [ForeignKey(nameof(DistrictID))]
        public virtual District DistrictFk { get; set; }

        [ForeignKey(nameof(WardID))]
        public virtual Ward WardFk { get; set; }

        [ForeignKey(nameof(DirectorID))]
        public virtual User DirectorFk { get; set; }
    }
}
