using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Loại bệnh nhân (đối tượng bệnh nhân).
    /// </summary>
    public class PatientType : AuditedEntity<int>
    {
        public string PatientTypeCode { get; set; }
        public string PatientTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public PatientType() { }
        public PatientType(int id, string name, int order)
        {
            this.Id = id;
            this.PatientTypeCode = id.ToString();
            this.PatientTypeName = name;
            this.SortOrder = order;
        }
    }
}
