﻿using HIS.Core.Domain.Entities;
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
    /// Chức năng của phần mềm.
    /// </summary>
    [Table("SYSSubSystem")]
    public class SYSSubSystem : Entity<string>
    {
        [MaxLength(255)]
        public override string Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Name { get; set; }

        [MaxLength(255)]
        public string ParentId { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int SortOrder { get; set; }


    }
}