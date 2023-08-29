using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Kết quả khám, chữa bệnh.
    /// </summary>
    public class MedicalRecordResult : AuditedEntity<int>
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int SortOrder { get; set; }
        public virtual bool Inactive { get; set; }

        public MedicalRecordResult() { }
        public MedicalRecordResult(int id, string code, string name, string description, int sortOrder, bool inactive)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
            this.Description = description;
            this.SortOrder = sortOrder;
            this.Inactive = inactive;
        }
    }
}
