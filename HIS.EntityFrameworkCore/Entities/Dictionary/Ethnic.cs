using HIS.Core.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Dictionary
{
    /// <summary>
    /// Dân tộc.
    /// </summary>
    [Table("DIEthnic")]
    public class Ethnic : Entity<Guid>
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

        public Ethnic() { }
        public Ethnic(Guid id, string code, string mohCode, string name, int sortOrder)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
            this.MediCode = mohCode;
            this.SortOrder = sortOrder;
        }
    }
}
