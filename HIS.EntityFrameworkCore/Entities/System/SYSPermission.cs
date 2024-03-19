using AutoMapper.Configuration.Annotations;
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
    public class SYSPermission : Entity<string>
    {
        [MaxLength(255)]
        public override string Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string SubSystemId { get; set; }

        [MaxLength(255)]
        [Required]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int SortOrder { get; set; }

        [ForeignKey(nameof(SubSystemId))]
        public virtual SYSSubSystem SubSystem { get; set; }
    }
}
