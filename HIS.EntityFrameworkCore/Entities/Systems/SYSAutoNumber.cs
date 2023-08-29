using HIS.Core.Entities;
using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    public class SYSAutoNumber : AuditedEntity<Guid>
    {
        public virtual string Prefix { get; set; }
        public virtual decimal Value { get; set; }
        public virtual int LengthOfValue { get; set; }
        public virtual string Suffix { get; set; }
        public virtual int RefTypeCategoryId { get; set; }
        public virtual Guid BranchId { get; set; }

        public virtual SYSRefTypeCategory RefTypeCategory { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
