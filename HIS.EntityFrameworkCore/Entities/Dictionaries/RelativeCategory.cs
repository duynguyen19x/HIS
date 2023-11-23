using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Mỗi quan hệ gia đình.
    /// </summary>
    public class RelativeCategory : AuditedEntity<Guid>
    {
        public string RelativeCategoryCode { get; set; }
        public string RelativeCategoryName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public RelativeCategory() { }
    }
}
