using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    public class TreatmentRecord : FullAuditedEntity<Guid>
    {
        public virtual DateTime TreatmentRecordDate { get; set; }

        public Guid TreatmentId { get; set; }

        public TreatmentRecord() { }
    }
}
