using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Thông tin bệnh án
    /// </summary>
    public class MedicalRecord : AuditedEntity<Guid>
    {
        public Guid PatientID { get; set; }
    }
}
