using HIS.Core.Entities;
using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Thời gian tử vong.
    /// </summary>
    public class DeathWithin : AuditedEntity<Guid>
    {
        public string DeathWithinCode { get; set; }
        public string DeathWithinName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public DeathWithin() { }
    }
}
