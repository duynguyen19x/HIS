using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin tử vong
    /// </summary>
    [Table("HISMedicalRecordDeath")]
    public class MedicalRecordDeath : AuditedEntity<Guid>
    {
        public virtual Guid PatientId { get; set; }

        public virtual Guid PatientRecordId { get; set; }

        public virtual Guid MedicalRecordId { get; set; }

        public virtual Guid? TreatmentId { get; set; }
    }
}
