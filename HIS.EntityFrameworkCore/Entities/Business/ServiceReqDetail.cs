using HIS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    public class ServiceReqDetail : Entity<Guid>
    {
        public virtual Guid ServiceReqId { get; set; }
        public virtual Guid ServiceId { get; set; }
    }
}
