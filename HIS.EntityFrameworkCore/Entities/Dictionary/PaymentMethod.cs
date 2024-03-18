using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Phương thức thanh toán.
    /// </summary>
    public class PaymentMethod : AuditedEntity<Guid>
    {
        public string PaymentMethodCode { get; set; }
        public string PaymentMethodName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public PaymentMethod() { }
    }
}
