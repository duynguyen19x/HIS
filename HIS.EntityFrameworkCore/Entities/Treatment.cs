using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Điều trị
    /// </summary>
    public class Treatment : AuditedEntity<Guid>
    {
        public Guid PatientID { get; set; }
        public Guid MedicalRecordID { get; set; }
        public Guid BranchID { get; set; }
        public Guid DepartmentID { get; set; }

    }
}
