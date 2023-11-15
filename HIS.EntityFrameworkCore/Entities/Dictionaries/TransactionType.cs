using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Loại thu, chi: thu tiền, tạm ứng, hoàn ứng,....
    /// </summary>
    public class TransactionType : AuditedEntity<int>
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int SortOrder { get; set; } // số thứ tự hiển thị
        public virtual bool Inactive { get; set; }
    }
}
