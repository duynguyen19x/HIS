using HIS.Core.Domain.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Đối tượng đăng ký khám.
    /// </summary>
    public class ReceptionObjectType : AuditedEntity<int>
    {
        public string ReceptionTypeCode { get; set; }
        public string ReceptionTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public ReceptionObjectType() { }
        public ReceptionObjectType(int id, string name, int order)
        {
            this.Id = id;
            this.ReceptionTypeCode = id.ToString();
            this.ReceptionTypeName = name;
            this.SortOrder = order;
        }
    }
}
