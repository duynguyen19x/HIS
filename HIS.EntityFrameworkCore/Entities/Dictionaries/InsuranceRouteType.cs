using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Loại tuyến KCB.
    /// </summary>
    public class InsuranceRouteType : AuditedEntity<int>
    {
        public string InsuranceRouteTypeCode { get; set; }
        public string InsuranceRouteTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}
