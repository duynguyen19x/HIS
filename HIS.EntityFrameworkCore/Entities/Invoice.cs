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
    /// Hóa đơn
    /// </summary>
    [Table("DInvoice")]
    public class Invoice : AuditedEntity<Guid>
    {
        public string InvoiceCode { get; set; }

        public DateTime InvoiceDate { get; set; }


    }
}
