using HIS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Chi tiết phiếu thu, chi.
    /// </summary>
    public class TransactionDetail : Entity<Guid>
    {
        public virtual Guid RefId { get; set; }
        public virtual int RefType { get; set; }
        public virtual Guid AccountBookId { get; set; }
        public virtual int TransactionTypeId { get; set; }
        public virtual string JournalMemo { get; set; }
        public virtual decimal TotalAmount { get; set; }
        public virtual int RefOrder { get; set; }
    }
}
