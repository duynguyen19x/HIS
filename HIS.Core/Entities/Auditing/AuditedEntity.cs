using HIS.Core.Entities;
using HIS.EntityFrameworkCore.BaseEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Entities.Auditing
{
    [Serializable]
    public abstract class AuditedEntity<TPrimaryKey> : CreationAuditedEntity<TPrimaryKey>, IAudited
    {
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual Guid? ModifiedBy { get; set; }
    }
}
