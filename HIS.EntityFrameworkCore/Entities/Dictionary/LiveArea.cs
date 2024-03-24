using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Nơi sống.
    /// </summary>
    [Table("DILiveArea")]
    public class LiveArea : AuditedEntity<Guid>
    {
        [MaxLength(50)]
        public string Code { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Mã BYT
        /// </summary>
        [MaxLength(50)]
        public string MediCode { get; set; }

        [MaxLength(255)] 
        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }

    }
}
