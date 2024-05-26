using HIS.Core.Application.Services.Dto;
using HIS.EntityFrameworkCore.Constants;
using System.ComponentModel.DataAnnotations;

namespace HIS.ApplicationService.Dictionary.Branchs.Dto
{
    /// <summary>
    /// Chi nhánh.
    /// </summary>
    public class BranchDto : EntityDto<Guid?>
    {
        public string BranchCode { get; set; }

        public string BranchName { get; set; }

        /// <summary>
        /// Mã khám chữa bệnh ban đầu
        /// </summary>
        public string MediOrgCode { get; set; }

        /// <summary>
        /// Mã KCBBĐ đúng tuyến (ngăn cách bởi dấu ;)
        /// </summary>
        public string MediOrgAcceptCode { get; set; }

        /// <summary>
        /// Hạng bệnh viện (hạng I, II, III và đặc biệt)
        /// </summary>
        public Guid? HospitalLevelID { get; set; }

        public string HospitalLevelName { get; set; }

        public string HospitalLevelCode { get; set; }

        /// <summary>
        /// Tuyến bệnh viện
        /// </summary>
        public Guid? HospitalLineID { get; set; }

        public string HospitalLineName { get; set; }

        public string HospitalLineCode { get; set; }

        /// <summary>
        /// Chuyên khoa
        /// </summary>
        public Guid? HospitalSpecialityID { get; set; }

        public string HospitalSpecialityName { get; set; }

        public string HospitalSpecialityCode { get; set; }

        /// <summary>
        /// Tên đơn vị quản lý (sở y tế/bộ y tế)
        /// </summary>
        public string ParentOrganizationName { get; set; }

        /// <summary>
        /// Điện thoại
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Địa chỉ (số nhà, thôn, xóm)
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Tỉnh, thành phố
        /// </summary>
        public Guid? ProvinceID { get; set; }

        public string ProvinceName { get; set; }

        public string ProvinceCode { get; set; }

        /// <summary>
        /// Quận, huyện
        /// </summary>
        public Guid? DistrictID { get; set; }

        public string DistrictName { get; set; }

        public string DistrictCode { get; set; }

        /// <summary>
        /// Xã, phường
        /// </summary>
        public Guid? WardID { get; set; }

        public string WardName { get; set; }

        public string WardCode { get; set; }

        /// <summary>
        /// Lãnh đạo
        /// </summary>
        public Guid? DirectorID { get; set; }

        public string DirectorName { get; set; }

        /// <summary>
        /// Ghi chú
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Số thứ tự hiển thị
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// Khóa
        /// </summary>
        public bool Inactive { get; set; }
    }
}
