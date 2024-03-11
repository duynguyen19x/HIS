﻿using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    /// <summary>
    /// Vai trò.
    /// </summary>
    [Table("SYSRole")]
    public class SYSRole : AuditedEntity<Guid>
    {
        [MaxLength(50)]
        [Required]
        public string Code { get; set; }

        [MaxLength(255)]
        [Required]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool IsSystem { get; set; }

        public bool Inactive { get; set; }
    }
}
