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
        #region hành chính

        [Required]
        [MaxLength(50)]
        public virtual string Code { get; set; }

        [Required]
        public virtual Guid PatientID { get; set; }

        [Required]
        [MaxLength(500)]
        public virtual string PatientName { get; set; }

        public DateTime? BirthDate { get; set; } // ngày sinh

        [Required]
        public int BirthYear { get; set; } // năm sinh

        [MaxLength(500)]
        public string BirthPlace { get; set; } // nơi sinh

        [MaxLength(50)]
        public virtual string IdentificationNumber { get; set; } // số CMND / CCCD

        public virtual DateTime? IssueDate { get; set; } // ngày cấp

        [MaxLength(500)]
        public virtual string IssueBy { get; set; } // nơi cấp

        [Required]
        public virtual Guid GenderID { get; set; } // giới tính

        [Required]
        public virtual Guid EthnicityID { get; set; } // dân tộc

        [Required]
        public virtual Guid CareerID { get; set; } // nghề nghiệp

        [Required]
        public virtual Guid CountryID { get; set; } // quốc gia

        public virtual string CountryCode { get; set; }

        public virtual string CountryName { get; set; }

        public virtual Guid? ProvinceID { get; set; } // tỉnh/ thành phố

        public virtual string ProvinceCode { get; set; }

        public virtual string ProvinceName { get; set; }

        public virtual Guid? DistrictID { get; set; } // quận/ huyện

        public virtual string DistrictCode { get; set; }

        public virtual string DistrictName { get; set; }

        public virtual Guid? WardID { get; set; } // xã, phường

        public virtual string WardCode { get; set; }

        public virtual string WardName { get; set; }

        [MaxLength(500)]
        public virtual string Address { get; set; } // địa chỉ (số nhà, thôn, phố, ...)

        [MaxLength(50)]
        public virtual string Tel { get; set; } // số điện thoại cố định

        [MaxLength(50)]
        public virtual string Mobile { get; set; } // số điện thoại di động

        [MaxLength(50)]
        public virtual string Fax { get; set; } // fax

        [MaxLength(50)]
        public virtual string Email { get; set; } // email

        [MaxLength(250)]
        public virtual string Workplace { get; set; } // nơi làm việc

        #endregion

        #region điều trị

        [Required]
        public virtual int PatientTypeID { get; set; } // đối tượng bệnh nhân (BHYT, viện phí, dịch vụ, ...)

        [Required]
        public virtual int PatientRecordTypeID { get; set; } // đối tượng điều trị (khám bệnh, nội trứ, ngoại trú, ...)

        [Required]
        public virtual int PatientRecordStatusID { get; set; } // trạng thái đợt điều trị


        [Required]
        public virtual DateTime ReceiptionDate { get; set; } // thơi gian đăng ký, tiếp nhận

        public virtual Guid ReceiptionRoomID { get; set; } // phòng tiếp đón

        public virtual Guid ReceiptionDepartmentID { get; set; } // khoa đón tiếp

        public virtual bool IsEmergency { get; set; } // là cấp cứu

        public virtual string HospitalizationReason { get; set; } // lý do nhập viện


        public virtual DateTime? StartDate { get; set; } // thời gian bắt đầu khám/ điều trị

        public virtual Guid? StartRoomID { get; set; } // phòng bắt đầu khám / điều trị

        public virtual Guid? StartDepartmentID { get; set; } // khoa bắt đầu khám / điều trị

        public virtual DateTime? EndDate { get; set; } // thời gian kết thúc điều trị

        public virtual Guid? EndRoomID { get; set; } // phòng kết thúc điều trị

        public virtual Guid? EndDepartmentID { get; set; } // khoa kết thúc điều trị


        public virtual Guid BranchID { get; set; } // chi nhánh

        #endregion

        #region khác

        [MaxLength(500)]
        public virtual string Description { get; set; }

        public virtual bool Inactive { get; set; }

        [Ignore]
        [ForeignKey(nameof(PatientID))]
        public virtual Patient PatientFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(GenderID))]
        public virtual Gender GenderFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(EthnicityID))]
        public virtual Ethnic EthnicityFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(CareerID))]
        public virtual Career CareerFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(CountryID))]
        public virtual Country CountryFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(ProvinceID))]
        public virtual Province ProvinceFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(DistrictID))]
        public virtual District DistrictFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(WardID))]
        public virtual SWard WardFk { get; set; }

        [Ignore]
        [ForeignKey(nameof(BranchID))]
        public virtual Branch BracnhFk { get; set; }

        #endregion
    }
}
