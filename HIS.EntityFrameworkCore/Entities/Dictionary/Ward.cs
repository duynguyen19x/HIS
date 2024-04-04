using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Xã, phường.
    /// </summary>
    [Table("DIWard")]
    public class Ward : AuditedEntity<Guid>
    {
        [Required]
        [MaxLength(50)]
        public virtual string Code { get; set; } 

        [Required]
        [MaxLength(255)]
        public virtual string Name { get; set; } 

        [MaxLength(2000)]
        public virtual string SearchText { get; set; } // viết tắt (T/H/X)

        [MaxLength(255)]
        public virtual string Description { get; set; } // ghi chú

        public virtual int SortOrder { get; set; } // số thứ tự hiển thị trên danh mục

        public virtual bool Inactive { get; set; } // khóa

        public virtual Guid DistrictId { get; set; }

        [ForeignKey("DistrictId")]
        public virtual District DistrictFk { get; set; }
    }
}
