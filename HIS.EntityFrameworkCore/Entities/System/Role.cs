using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Vai trò.
    /// </summary>
    [Table("SRole")]
    public class Role : AuditedEntity<Guid>
    {
        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Là quyền mặc định của hệ thống (người dùng không được phép chỉnh sửa)
        /// </summary>
        public bool IsDefault { get; set; }

        public bool Inactive { get; set; }

        public int SortOrder { get; set; }
    }
}
