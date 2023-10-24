using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    public class ServiceRequest : FullAuditedEntity<Guid>
    {
        public Guid PatientId { get; set; }
        public Guid PatientRecordId { get; set; }
        public Guid MedicalRecordId { get; set; }
        public Guid TreatmentId { get; set; }

        public string Code { get; set; }
        public DateTime RequestTime { get; set; }
        public string Description { get; set; }
    }
}
