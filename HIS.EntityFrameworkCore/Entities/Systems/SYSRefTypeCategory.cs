using HIS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    public class SYSRefTypeCategory : Entity<int>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int SortOrder { get; set; }
        public virtual bool Inactive { get; set; }

        public virtual ICollection<SYSAutoNumber> AutoNumbers { get; set; }
        public virtual ICollection<SYSRefType> RefTypes { get; set; }
        
    }
}
