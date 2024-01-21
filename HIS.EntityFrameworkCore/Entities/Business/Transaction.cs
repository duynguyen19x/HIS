using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Giao dịch thu, chi
    /// </summary>
    public class Transaction : AuditedEntity<Guid>
    {
        public string TransactionCode { get; set; }

        public Transaction() { }
    }
}
