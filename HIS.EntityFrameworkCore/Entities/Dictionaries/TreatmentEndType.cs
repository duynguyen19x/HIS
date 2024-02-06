﻿using HIS.Core.Domain.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Hình thức xử trí.
    /// </summary>
    public class TreatmentEndType : AuditedEntity<int>
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual bool IsForOutPatient { get; set; } // dùng cho bệnh nhân khám bệnh và điều trị ngoại trú
        public virtual bool IsForInPatient { get; set; } // dùng cho bệnh nhân điều trị nội trú
        public virtual string Description { get; set; }
        public virtual int SortOrder { get; set; }
        public virtual bool Inactive { get; set; }

        public TreatmentEndType() { }
    }
}
