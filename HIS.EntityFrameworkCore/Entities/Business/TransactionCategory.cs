using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Sổ thu, chi.
    /// </summary>
    public class TransactionCategory : FullAuditedEntity<Guid>
    {
        public string TransactionCategoryCode { get; set; }
        public string TransactionCategoryName { get; set; }

        public TransactionCategory() { }
    }
}
