using HIS.Core.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Kết quả điều trị.
    /// </summary>
    public class TreatmentResult : AuditedEntity<int>
    {
        public string TreatmentResultCode { get; set; }
        public string TreatmentResultName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public TreatmentResult() { }
    }
}
