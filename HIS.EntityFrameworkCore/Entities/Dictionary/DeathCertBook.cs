using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Sổ giấy báo tử.
    /// </summary>
    [Table("SDeathCertBook")]
    public class DeathCertBook : AuditedEntity<Guid>
    {
        /// <summary>
        /// Mã sổ
        /// </summary>
        [Required]
        [MaxLength(50)]
        public virtual string Code { get; set; }

        /// <summary>
        /// Tên sổ
        /// </summary>
        [Required]
        [MaxLength(255)]
        public virtual string Name { get; set; }

        /// <summary>
        /// Tổng số giấy chứng sinh
        /// </summary>
        [Required]
        public virtual int Total {  get; set; }

        /// <summary>
        /// Số bắt đầu
        /// </summary>
        [Required]
        public virtual int StartNumOrder { get; set; }

        public virtual int SortOrder { get; set; }

        [MaxLength(255)]
        public virtual string Description { get; set; }

        /// <summary>
        /// Chi nhánh tạo sổ
        /// </summary>
        public virtual Guid BranchId { get; set; }

        /// <summary>
        /// Khóa
        /// </summary>
        public virtual bool Inactive { get; set; }

        [ForeignKey("BranchId")]
        public virtual Branch BranchFk { get; set; }
    }
}
