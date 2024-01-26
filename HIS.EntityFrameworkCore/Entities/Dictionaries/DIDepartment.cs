using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Khoa.
    /// </summary>
    public class DIDepartment : AuditedEntity<Guid>
    {
        /// <summary>
        /// Mã khoa.
        /// </summary>
        public string DepartmentCode { get; set; }

        /// <summary>
        /// Tên khoa.
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// Mã khoa (BYT)
        /// </summary>
        public string MediCode { get; set; }

        /// <summary>
        /// Loại khoa.
        /// </summary>
        public int DepartmentTypeID { get; set; }

        /// <summary>
        /// Thuộc chi nhánh.
        /// </summary>
        public Guid BranchId { get; set; }

        /// <summary>
        /// Trưởng khoa.
        /// </summary>
        public Guid? ChiefID { get; set; }

        /// <summary>
        /// Điện thoại.
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Địa chỉ.
        /// </summary>
        public string Email { get; set; }

        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }

        [Ignore]
        public virtual DepartmentType DepartmentTypeFk { get; set; }

        [Ignore]
        public virtual DIBranch BranchFk { get; set; }

        [Ignore]
        public virtual DIEmployee ChiefFk { get; set; }
    }
}
