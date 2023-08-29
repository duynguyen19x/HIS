using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Xử trí khám bệnh, hình thức ra viện.
    /// </summary>
    public class MedicalRecordEndType : AuditedEntity<int>
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual bool IsForOutPatient { get; set; } // dùng cho bệnh nhân khám bệnh và điều trị ngoại trú
        public virtual bool IsForInPatient { get; set; } // dùng cho bệnh nhân điều trị nội trú
        public virtual string Description { get; set; }
        public virtual int SortOrder { get; set; }
        public virtual bool Inactive { get; set; }

        public MedicalRecordEndType() { }
        public MedicalRecordEndType(int id, string code, string name, bool isForOutPatient, bool isForInPatient, int sortOrder)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
            this.IsForOutPatient = isForOutPatient;
            this.IsForInPatient = isForInPatient;
            this.Description = null;
            this.SortOrder = sortOrder;
            this.Inactive = false;
        }
    }
}
