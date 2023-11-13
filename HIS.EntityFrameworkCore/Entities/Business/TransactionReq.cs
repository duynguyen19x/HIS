using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Yêu cầu thanh toán, tạm ứng.
    /// </summary>
    public class TransactionReq : FullAuditedEntity<Guid>
    {
        public TransactionReq() { }
    }
}
