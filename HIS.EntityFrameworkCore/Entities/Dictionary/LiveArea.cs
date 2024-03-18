using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Nơi sống.
    /// </summary>
    public class LiveArea : AuditedEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string MohCode { get; set; } 
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public LiveArea() { }
    }
}
