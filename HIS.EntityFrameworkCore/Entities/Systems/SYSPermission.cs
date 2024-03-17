using HIS.Core.Domain.Entities;
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
    /// Quyền hạn.
    /// </summary>
    [Table("SYSPermission")]
    public class SYSPermission : Entity<string>
    {
        [MaxLength(100)]
        [Required]
        public override string Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [MaxLength(100)]
        public string ParentId { get; set; }

        public int SortOrder { get; set; }
    }
}
