using HIS.EntityFrameworkCore.BaseEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Entities.Auditing
{
    [Serializable]
    public abstract class CreationAuditedEntity<TPrimaryKey> : Entity<TPrimaryKey>, ICreationAudited
    {
        public DateTime CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }

        public CreationAuditedEntity()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
