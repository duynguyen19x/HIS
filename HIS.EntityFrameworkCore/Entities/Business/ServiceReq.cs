using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Phiếu chỉ định dịch vụ.
    /// </summary>
    public class ServiceReq : FullAuditedEntity<Guid>
    {
        public virtual string Code { get; set; }
    }
}
