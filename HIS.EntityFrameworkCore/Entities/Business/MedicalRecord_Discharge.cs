using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Bệnh án ra viện.
    /// </summary>
    public class MedicalRecord_Discharge : AuditedEntity<Guid>
    {
        public virtual Guid PatientRecordID { get; set; }
        public virtual Guid MedicalRecordID { get; set; }


    }
}
