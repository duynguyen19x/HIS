using HIS.Core.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Loại bệnh nhân.
    /// </summary>
    public class PatientType : AuditedEntity<int>
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int SortOrder { get; set; }
        public virtual bool Inactive { get; set; }
    }
}
