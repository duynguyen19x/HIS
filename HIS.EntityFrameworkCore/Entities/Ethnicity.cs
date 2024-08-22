using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Dân tộc.
    /// </summary>
    [Table("SEthnicities")]
    public class Ethnicity : AuditedEntity<Guid>
    {
        /// <summary>
        /// Mã dân tộc
        /// </summary>
        [Required]
        [MaxLength(50)]
        public virtual string Code { get; set; }

        /// <summary>
        /// Tên dân tộc
        /// </summary>
        [Required]
        [MaxLength(255)]
        public virtual string Name { get; set; }

        /// <summary>
        /// Mã dân tộc (BYT)
        /// </summary>
        [MaxLength(50)]
        public virtual string MediCode { get; set; }

        [MaxLength(255)]
        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }

        public virtual bool Inactive { get; set; }

        public Ethnicity() { }
        public Ethnicity(Guid id, string code, string mohCode, string name, int sortOrder, DateTime? createTime = null)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
            this.MediCode = mohCode;
            this.SortOrder = sortOrder;
            this.CreatedDate = createTime;
        }
    }
}
