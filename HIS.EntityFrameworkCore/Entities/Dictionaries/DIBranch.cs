using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Chi nhánh.
    /// </summary>
    public class DIBranch : AuditedEntity<Guid>
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
        /// Hạng bệnh viện (hạng I, II, III và đặc biệt).
        /// </summary>
        public string Level { get; set; } 

        /// <summary>
        /// Loại bệnh viện, chuyên khoa (nội, ngoại, yhct, ....).
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

        /// <summary>
        /// Tỉnh, thành phố.
        /// </summary>
        public Guid? ProvinceID { get; set; }

        /// <summary>
        /// Quận, huyện.
        /// </summary>
        public Guid? DistrictID { get; set; }

        /// <summary>
        /// Xã, phường.
        /// </summary>
        public Guid? WardID { get; set; }

        /// <summary>
        /// Lãnh đạo.
        /// </summary>
        public Guid? DirectorID { get; set; }

        /// <summary>
        /// Điện thoại.
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Địa chỉ.
        /// </summary>
        public string Address { get; set; }

        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }

        [Ignore]
        public Province ProvinceFk { get; set; }

        [Ignore]
        public District DistrictFk { get; set; }

        [Ignore]
        public Ward WardFk { get; set; }

        [Ignore]
        public virtual DIEmployee DirectorFk { get; set; }
    }
}
