using HIS.EntityFrameworkCore.BaseEntitys;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business.Patients
{
    public class SPatient : FullAuditingEntity<Guid>
    {
        /// <summary>
        /// Mã BN
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Tên đầy đủ
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Tên
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Họ
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Giới tinh
        /// </summary>
        public Guid? GenderId { get; set; }
        /// <summary>
        /// Đối tượng BN
        /// </summary>
        public Guid PatientTypeId { get; set; }
        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime? DOB { get; set; }
        /// <summary>
        /// Năm sinh (bắt buộc)
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Dân tộc
        /// </summary>
        public Guid? EthnicId { get; set; }
        /// <summary>
        /// Quốc tịch
        /// </summary>
        public Guid? CountryId { get; set; }
        /// <summary>
        /// Tỉnh/Thành phố
        /// </summary>
        public Guid? ProvinceId { get; set; }
        /// <summary>
        /// Huyện/Quận
        /// </summary>
        public Guid? DistrictId { get; set; }
        /// <summary>
        /// Xã/Phường
        /// </summary>
        public Guid? WardId { get; set; }
        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Điện thoại di động
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// Điện thoại cố định
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Thư điện tử
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// NGhề nghiệp
        /// </summary>
        public Guid? CareerId { get; set; }
        /// <summary>
        /// Chi nhánh
        /// </summary>
        public Guid? BranhId { get; set; }
        /// <summary>
        /// Căn cước công dân
        /// </summary>
        public string IdentificationNumber { get; set; }
        /// <summary>
        /// Nơi cấp
        /// </summary>
        public string IdentificationNumberIssuedBy { get; set; }
        /// <summary>
        /// Ngày cấp
        /// </summary>
        public DateTime? IdentificationNumberIssuedDate { get; set; }
        /// <summary>
        /// Tên người nhà
        /// </summary>
        public string RelativeName { get; set; }
        /// <summary>
        /// Địa chỉ người nhà
        /// </summary>
        public string RelativeAddress { get; set; }
        /// <summary>
        /// Số CMND/CCCD người nhà
        /// </summary>
        public string RelativeIdentificationNumber { get; set; }
        /// <summary>
        /// Số điện thaoij người nhà
        /// </summary>
        public string RelativePhoneNumbar { get; set; }
        /// <summary>
        /// Thẻ BHYT
        /// </summary>
        public Guid? HeinCardId { get; set; }
        public string TaxCode { get; set; }
        /// <summary>
        /// Họ tên bố 
        /// </summary>
        public string PatientFather { get; set; }
        /// <summary>
        /// Trình dộ học vấn của bố
        /// </summary>
        public string FatherEducationalLevel { get; set; }
        /// <summary>
        /// Họ tên mẹ
        /// </summary>
        public string PatientMother { get; set; }
        /// <summary>
        /// Trình dộ học vấn của mẹ
        /// </summary>
        public string MotherEducationalLevel { get; set; }
        /// <summary>
        /// Thời hạn tham gia đủ 5 năm liên tục
        /// </summary>
        public DateTime? Join5Year { get; set; }
        /// <summary>
        /// Số hộ chiếu
        /// </summary>
        public string PassPortNumber { get; set; }
        /// <summary>
        /// Ngày cấp hộ chiếu
        /// </summary>
        public DateTime? PassPortDate { get; set; }
        /// <summary>
        /// Nơi cấp hộ chiếu
        /// </summary>
        public string PassPortIssuedBy { get; set; }

        public SPatientType PatientType { get; set; }
        public SGender Gender { get; set; }
    }
}
