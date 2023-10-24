using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    public class SYSDbOption : AuditedEntity<Guid>
    {
        public string OptionId { get; set; }
        public string OptionValue { get; set; }
        public string OptionValueDefault { get; set; }
        public int OptionValueType { get; set; }
        public string Description { get; set; }
        public bool IsUserOption { get; set; }
        public Guid? UserId { get; set; }
        public bool IsBranchOption { get; set; }
        public Guid? BranchId { get; set; }
    }
}
