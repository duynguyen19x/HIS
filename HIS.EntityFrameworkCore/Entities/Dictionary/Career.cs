﻿using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Dictionary
{
    /// <summary>
    /// Nghề nghiệp.
    /// </summary>
    [Table("SCareer")]
    public class Career : AuditedEntity<Guid>
    {
        [MaxLength(50)]
        [Required]
        public virtual string Code { get; set; }

        [MaxLength(255)]
        [Required]
        public virtual string Name { get; set; }

        [MaxLength(255)]
        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }

        public virtual bool Inactive { get; set; }
    }
}
