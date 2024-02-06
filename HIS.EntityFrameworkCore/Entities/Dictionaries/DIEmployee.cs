using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Nhân viên.
    /// </summary>
    [Table("DIEmployee")]
    public class DIEmployee : AuditedEntity<Guid>
    {
        /// <summary>
        /// Mã nhân viên.
        /// </summary>
        [Required]
        [MaxLength(50)]
        public virtual string Code { get; set; }

        /// <summary>
        /// Tên nhân viên.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public virtual string Name { get; set; }

        /// <summary>
        /// Ghi chú
        /// </summary>
        [MaxLength(255)]
        public virtual string Description { get; set; }

        /// <summary>
        /// Số thứ tự hiển thị
        /// </summary>
        public virtual int SortOrder { get; set; }

        /// <summary>
        /// Khóa
        /// </summary>
        public virtual bool Inactive { get; set; }
    }
}
