using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    public class ServiceInvoice : AuditedEntity<Guid>
    {
        public Guid InvoiceId { get; set; }
        public Guid ServiceRequestId { get; set; }
        public Guid ServiceId { get; set; }
        public Guid BranchId { get; set; }
    }
}
