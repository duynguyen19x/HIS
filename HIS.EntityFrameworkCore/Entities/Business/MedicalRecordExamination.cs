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
    /// Thông tin khám bệnh
    /// </summary>
    [Table("HISMedicalRecordExamination")]
    public class MedicalRecordExamination : AuditedEntity<Guid>
    {
        public virtual Guid PatientId { get; set; }

        public virtual Guid PatientRecordId { get; set; }

        public virtual Guid MedicalRecordId { get; set; }

        public virtual Guid? TreatmentId { get; set; }
    }
}
