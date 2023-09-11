using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Danh sách dịch vụ được chỉ định.
    /// </summary>
    public class ServiceReqServe : FullAuditedEntity<Guid>
    {
        public virtual Guid ServiceReqId { get; set; }
        public virtual Guid ServiceId { get; set; }

        public virtual Guid ExecuteDepartmentId { get; set; }
        public virtual Guid ExecuteRoomId { get; set; }
        public virtual Guid ExecuteUserId { get; set; }
    }
}
