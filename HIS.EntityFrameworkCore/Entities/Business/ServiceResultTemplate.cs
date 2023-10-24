using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Mẫu kết quả thực hiện dịch vụ.
    /// </summary>
    public class ServiceResultTemplate : AuditedEntity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid ServiceId { get; set; }
    }
}
