﻿using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.System
{
    /// <summary>
    /// Quyền hạn.
    /// </summary>
    [Table("SYSPermission")]
    public class Permission : Entity<int>
    {
        [MaxLength(255)]
        [Required]
        public virtual string SubSystemId { get; set; }

        [MaxLength(255)]
        [Required]
        public virtual string Name { get; set; }

        [MaxLength(255)]
        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }

        [ForeignKey(nameof(SubSystemId))]
        public SubSystem SubSystem { get; set; }
    }
}
