using HIS.Core.Entities.Auditing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Nhóm máu Rh
    /// </summary>
    [Table("BloodTypeRh")]
    [PrimaryKey(nameof(Id))]
    public class BloodTypeRh : AuditedEntity<Guid>
    {
        [Required]
        [MaxLength(20)]
        public virtual string Code { get; set; }

        [Required]
        [MaxLength(256)]
        public virtual string Name { get; set; }

        [MaxLength(512)]
        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }

        public virtual bool Inactive { get; set; }
    }
}
