using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Nhóm loại bệnh án.
    /// </summary>
    [Table("SMedicalRecordTypeGroup")]
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
