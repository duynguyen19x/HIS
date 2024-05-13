using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Hóa đơn thanh toán cho dịch vụ được chỉ định
    /// </summary>
    [Table("DServiceInvoice")]
    public class ServiceInvoice : AuditedEntity<Guid>
    {
        public Guid InvoiceID { get; set; }
        public Guid ServiceRequestID { get; set; }
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}
