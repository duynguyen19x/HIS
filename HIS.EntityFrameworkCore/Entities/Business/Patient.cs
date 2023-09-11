using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin định danh bệnh nhân.
    /// </summary>
    public class Patient : FullAuditedEntity<Guid>
    {
        [Required]
        [MaxLength(50)]
        public virtual string Code { get; set; }

        [Required]
        [MaxLength(500)]
        public virtual string Name { get; set; }

        /// <summary>
        /// Nhóm máu
        /// </summary>
        public virtual int? BloodTypeId { get; set; }

        /// <summary>
        /// Nhóm máu Rh
        /// </summary>
        public virtual int? BloodRhId { get; set; }

        [MaxLength(500)]
        public virtual string Description { get; set; }

        public bool Inactive { get; set; }
    }
}
