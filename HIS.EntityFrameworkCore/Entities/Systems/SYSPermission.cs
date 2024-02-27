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
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public string ParentID { get; set; }

        public int SortOrder { get; set; }
    }
}
