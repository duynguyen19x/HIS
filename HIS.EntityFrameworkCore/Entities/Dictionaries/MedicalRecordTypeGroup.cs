using HIS.Core.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Nhóm loại bệnh án.
    /// </summary>
    public class MedicalRecordTypeGroup : AuditedEntity<int>
    {
        public string MedicalRecordTypeGroupCode { get; set; }
        public string MedicalRecordTypeGroupName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public MedicalRecordTypeGroup() { }
        public MedicalRecordTypeGroup(int id, string name, int order)
        {
            this.Id = id;
            this.MedicalRecordTypeGroupCode = id.ToString();
            this.MedicalRecordTypeGroupName = name;
            this.SortOrder = order;
        }
    }
}
