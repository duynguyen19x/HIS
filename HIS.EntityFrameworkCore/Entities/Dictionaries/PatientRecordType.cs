using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Loại hồ sơ bệnh án.
    /// </summary>
    public class PatientRecordType : AuditedEntity<int>
    {
        public string PatientRecordTypeCode { get; set; }
        public string PatientRecordTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public PatientRecordType() { }
    }
}
