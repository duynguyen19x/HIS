using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    public class TreatmentEndType : AuditedEntity<int>
    {
        public string TreatmentEndTypeCode { get; set; }
        public string TreatmentEndTypeName { get; set; }
        public bool IsForOutPatient { get; set; } // dùng cho bệnh nhân khám bệnh và điều trị ngoại trú
        public bool IsForInPatient { get; set; } // dùng cho bệnh nhân điều trị nội trú
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public TreatmentEndType() { }
    }
}
