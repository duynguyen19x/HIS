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
    public class ServiceRequestDetail : AuditedEntity<Guid>
    {
        public virtual Guid ServiceRequestID { get; set; }
        public virtual Guid ServiceID { get; set; }

        public virtual string Description { get; set; }
    }
}
