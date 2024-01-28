using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    [Table("SYSRefTypeCategory")]
    public class SYSRefTypeCategory : AuditedEntity<int>
    {
        [MaxLength(255)]
        [Required]
        public string RefTypeCategoryName { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int SortOrder {  get; set; } 
    }
}
