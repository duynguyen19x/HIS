﻿using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.System
{
    /// <summary>
    /// Nhóm báo cáo.
    /// </summary>
    [Table("SYSReportCategory")]
    public class SYSReportCategory : AuditedEntity<int>
    {
        [MaxLength(255)]
        [Required]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int SortOrder { get; set; }
    }
}
