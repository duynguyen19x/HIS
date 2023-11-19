using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin chuyển viện.
    /// </summary>
    public class Transfer : FullAuditedEntity<Guid>
    {
        public virtual Guid TreatmentId { get; set; }
        public virtual Guid? TreatmentRecordId { get; set; }
        public virtual Guid BranchId { get; set; }
        public virtual string TransferCode { get; set; }
    }
}
