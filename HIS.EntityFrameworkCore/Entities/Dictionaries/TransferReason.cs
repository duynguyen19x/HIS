using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Hình thức chuyển viện.
    /// </summary>
    public class TransferReason : AuditedEntity<Guid>
    {
        public string TransferReasonCode { get; set; }
        public string TransferReasonName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public TransferReason() { }
    }
}
