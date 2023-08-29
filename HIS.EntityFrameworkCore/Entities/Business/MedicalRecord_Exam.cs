using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Bệnh án khám bệnh.
    /// </summary>
    public class MedicalRecord_Exam : AuditedEntity<Guid>
    {
        
        public virtual Guid PatientRecordID { get; set; }
        public virtual Guid MedicalRecordID { get; set; }
        public virtual Guid DepartmentID { get; set; }
        public virtual Guid RoomID { get; set; }

        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
    }
}
