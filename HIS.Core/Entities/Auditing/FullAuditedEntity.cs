using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.EntityFrameworkCore.BaseEntitys;

namespace HIS.Core.Entities.Auditing
{
    [Serializable]
    public abstract class FullAuditedEntity<TPrimaryKey> : AuditedEntity<TPrimaryKey>, IFullAudited
    {
        public virtual DateTime? DeletedDate { get; set; }

        public virtual Guid? DeletedBy { get; set; }

        public virtual bool IsDeleted { get; set; }
    }
}
