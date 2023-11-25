using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Phiếu điều trị.
    /// </summary>
    public class Treatment : FullAuditedEntity<Guid>
    {
        public Guid MedicalRecordID { get; set; }

        public Treatment() { }
    }
}
