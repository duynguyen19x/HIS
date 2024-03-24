using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.Branchs.Dto
{
    /// <summary>
    /// Chi nhánh.
    /// </summary>
    public class BranchDto : EntityDto<Guid?>
    {
        /// <summary>
        /// Mã chi nhánh.
        /// </summary>
        public string BranchCode { get; set; }

        /// <summary>
        /// Tên chi nhánh.
        /// </summary>
        public string BranchName { get; set; }

        /// <summary>
        /// Mã khám chữa bệnh ban đầu.
        /// </summary>
        public string MediOrgCode { get; set; }

        /// <summary>
        /// Mã KCBBĐ đúng tuyến (ngăn cách bởi dấu ;)
        /// </summary>
        public string MediOrgAcceptCode { get; set; }

        /// <summary>
        /// Hạng bệnh viện.
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// Loại bệnh viện.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Tuyến bệnh viện.
        /// </summary>
        public string Line { get; set; }

        /// <summary>
        /// Tên đơn vị quản lý (sở y tế/bộ y tế)
        /// </summary>
        public string ParentOrganizationName { get; set; }

        public Guid? ProvinceId { get; set; }

        public Guid? DistrictId { get; set; }

        public Guid? WardId { get; set; }

        public string Tel { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }
    }
}
