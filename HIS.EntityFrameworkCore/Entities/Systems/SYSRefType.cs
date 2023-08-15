using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    public class SYSRefType : AuditedEntity<int>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int SortOrder { get; set; }
        public virtual int RefTypeCategoryId { get; set; }

        public virtual SYSRefTypeCategory RefTypeCategory { get; set; }
    }
}
