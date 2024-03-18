using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Sổ thu chi.
    /// </summary>
    public class TransactionGroup : AuditedEntity<Guid>
    {
        public string TransactionGroupCode { get; set; }
        public string TransactionGroupName { get; set; }
        public int Total { get; set; } // tổng số phiếu
        public int StartNumOrder { get; set; } // số bắt đầu
        public int NumOrder { get; set; } // số hiện tại
        public string TemplateNo { get; set; } // mẫu số
        public string SymbolNo { get; set; } // ký hiệu
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}
