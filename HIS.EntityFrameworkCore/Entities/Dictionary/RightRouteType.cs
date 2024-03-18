using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Tuyến KCB.
    /// </summary>
    public class RightRouteType : AuditedEntity<int>
    {
        public string RightRouteTypeCode { get; set; }
        public string RightRouteTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public RightRouteType() { }
    }
}
