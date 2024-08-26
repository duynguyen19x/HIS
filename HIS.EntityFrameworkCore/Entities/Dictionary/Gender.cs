using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Giới tính.
    /// </summary>
    [Table("SGenders")]
    public class Gender : AuditedEntity<int>
    {
        [Required]
        [StringLength(GenderConst.MaxGenderCodeLength, MinimumLength = GenderConst.MinGenderCodeLength)]
        public string Code { get; set; }

        [Required]
        [StringLength(GenderConst.MaxGenderNameLength, MinimumLength = GenderConst.MinGenderNameLength)]
        public string Name { get; set; }

        [StringLength(GenderConst.MaxDescriptionLength, MinimumLength = GenderConst.MinDescriptionLength)]
        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }
    }
}
