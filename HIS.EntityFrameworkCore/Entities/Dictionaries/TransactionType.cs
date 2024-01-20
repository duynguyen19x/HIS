using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Loại giao dịch thu, chi.
    /// </summary>
    public class TransactionType : AuditedEntity<int>
    {
        public string TransactionTypeCode { get; set; }
        public string TransactionTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public TransactionType() { }
        public TransactionType(int id, string name, int order)
        {
            this.Id = id;
            this.TransactionTypeCode = id.ToString();
            this.TransactionTypeName = name;
            this.SortOrder = order;
        }
    }
}
