using HIS.Core.Entities;
using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Nhóm máu.
    /// </summary>
    public class BloodType : AuditedEntity<Guid>
    {
        [MaxLength(50)]
        [Required]
        public virtual string Code { get; set; }

        [MaxLength(250)]
        [Required]
        public virtual string Name { get; set; }

        [MaxLength(500)]
        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }

        public virtual bool Inactive { get; set; }
    }
}
