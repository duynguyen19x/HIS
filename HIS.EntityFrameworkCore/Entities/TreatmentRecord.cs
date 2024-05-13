using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Tờ điều trị
    /// </summary>
    public class TreatmentRecord : AuditedEntity<Guid>
    {
        public string TreatmentRecordCode { get; set; }

        public DateTime TreatmentRecordDate { get; set; }

        public Guid TreatmentID { get; set; }
    }
}
