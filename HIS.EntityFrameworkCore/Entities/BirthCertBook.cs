using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Sổ giấy chứng sinh
    /// </summary>
    [Table("SBirthCertBooks")]
    public class BirthCertBook : AuditedEntity<Guid>
    {
        [Required]
        [StringLength(BirthCertBookConst.MaxBirthCertBookCodeLength, MinimumLength = BirthCertBookConst.MinBirthCertBookCodeLength)]
        public string Code { get; set; } // mã sổ

        [Required]
        [StringLength(BirthCertBookConst.MaxBirthCertBookNameLength, MinimumLength = BirthCertBookConst.MinBirthCertBookNameLength)]
        public string Name { get; set; } // tên sổ

        /// <summary>
        /// Tổng số giấy chứng sinh
        /// </summary>
        [Required]
        public int Total { get; set; }

        /// <summary>
        /// Số bắt đầu
        /// </summary>
        [Required]
        public int StartNumOrder { get; set; }

        public int SortOrder { get; set; }

        [StringLength(BirthCertBookConst.MaxDescriptionLength, MinimumLength = BirthCertBookConst.MinDescriptionLength)]
        public string Description { get; set; }

        public bool Inactive { get; set; }

        public Guid BranchId { get; set; }

        [ForeignKey("BranchId")]
        public virtual Branch BranchFK { get; set; }
    }
}
