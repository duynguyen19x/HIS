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
        public virtual Guid TransactionId { get; set; }
        public virtual Guid ServiceReqId { get; set; }
        public virtual Guid ServiceReqDetailId { get; set; }
        public virtual Guid ServiceId { get; set; }
        public virtual Guid UnitId { get; set; }
        public virtual decimal Price { get; set; } // đơn giá
        public virtual decimal HeinPrice { get; set; } // đơn giá BHYT
        public virtual decimal Quantity { get; set; }
        public virtual decimal Amount { get; set; }

    }
}
