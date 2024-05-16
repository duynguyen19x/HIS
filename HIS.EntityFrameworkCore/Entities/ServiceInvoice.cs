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
        public Guid InvoiceID { get; set; }
        public Guid ServiceRequestID { get; set; }
        public Guid ServiceID { get; set; }
        public Guid BranchID { get; set; }
    }
}
