using HIS.Core.Domain.Entities.Auditing;
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
    /// Nơi sống (khu vực: I, II, III)
    /// </summary>
    [Table("SLiveAreas")]
    public class LiveArea : AuditedEntity<Guid>
    {
        [MaxLength(50)]
        [Required]
        public virtual string Code { get; set; }

        [MaxLength(255)]
        [Required]
        public virtual string Name { get; set; }

        /// <summary>
        /// Mã BYT
        /// </summary>
        [MaxLength(50)]
        public virtual string MediCode { get; set; }

        [MaxLength(255)]
        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }

        public virtual bool Inactive { get; set; }

    }
}
