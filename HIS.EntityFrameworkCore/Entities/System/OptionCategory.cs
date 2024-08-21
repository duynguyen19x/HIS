using HIS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Nhóm tùy chọn.
    /// </summary>
    [Table("SOptionCategorys")]
    public class OptionCategory : Entity<int>
    {
        [MaxLength(128)]
        [Required]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int SortOrder { get; set; }
    }
}
