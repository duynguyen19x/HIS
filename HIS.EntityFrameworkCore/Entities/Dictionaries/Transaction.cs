using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Phiếu thu, chi.
    /// </summary>
    public class Transaction : FullAuditedEntity<Guid>
    {
        public string Code { get; set; }
        public virtual DateTime TransactionDate { get; set; }
        public virtual int TransactionTypeId { get; set; }
        public virtual Guid AccountBookId { get; set; }

    }
}
