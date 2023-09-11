using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Chi tiết phiếu chỉ định dịch vụ
    /// </summary>
    public class ServiceRequestServe : AuditedEntity<Guid>
    {
        public virtual Guid ServiceRequestId { get; set; }
        public virtual Guid ServiceId { get; set; }
        public virtual string ServiceCode { get; set; }
        public virtual string ServiceName { get; set; }

        public virtual decimal UnitPrice { get; set; }
        public virtual decimal Quantity { get; set; }

        public virtual string Description { get; set; }
    }
}
