using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Hóa đơn thanh toán
    /// </summary>
    public class Invoice : AuditedEntity<Guid>
    {
        public string InvoiceCode { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int InvoiceTypeID { get; set; }
    }
}
