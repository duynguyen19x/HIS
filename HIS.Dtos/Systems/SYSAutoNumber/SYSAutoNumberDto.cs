using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Systems.SYSAutoNumber
{
    public class SYSAutoNumberDto
    {
        public virtual string Prefix { get; set; }
        public virtual decimal Value { get; set; }
        public virtual int LengthOfValue { get; set; }
        public virtual string Suffix { get; set; }
        public virtual int RefTypeCategoryId { get; set; }
        public virtual Guid BranchId { get; set; }
    }
}
