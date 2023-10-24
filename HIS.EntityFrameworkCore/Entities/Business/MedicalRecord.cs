using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    public class MedicalRecord : FullAuditedEntity<Guid>
    {
        public Guid PatientId { get; set; }
        public Guid PatientRecordId { get; set; }

    }
}
