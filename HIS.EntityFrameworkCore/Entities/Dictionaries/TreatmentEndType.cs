using HIS.Core.Domain.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Hình thức xử trí.
    /// </summary>
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
