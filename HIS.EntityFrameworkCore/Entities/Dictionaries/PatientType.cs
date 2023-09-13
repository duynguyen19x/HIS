using HIS.Core.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Đói tượng bệnh nhân.
    /// </summary>
    public class PatientType : AuditedEntity<int>
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int SortOrder { get; set; }
        public virtual bool Inactive { get; set; }

        public PatientType() { }
        public PatientType(int id, string code, string name, string description, int sortOrder, bool inactive)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
            this.Description = description;
            this.SortOrder = sortOrder;
            this.Inactive = inactive;

            this.CreatedDate = new DateTime(1975, 01, 01);
        }
    }
}
