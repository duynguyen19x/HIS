using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Đối tượng bệnh nhân.
    /// </summary>
    public class PatientObjectType : AuditedEntity<int>
    {
        public string PatientObjectTypeCode { get; set; }
        public string PatientObjectTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public PatientObjectType() { }
        public PatientObjectType(int id, string name, int order)
        {
            this.Id = id;
            this.PatientObjectTypeCode = id.ToString();
            this.PatientObjectTypeName = name;
            this.SortOrder = order;
        }
    }
}
