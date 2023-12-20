using HIS.Core.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Loại mối quan hệ gia đình.
    /// </summary>
    public class RelativeType : AuditedEntity<Guid>
    {
        public string RelativeTypeCode { get; set; }
        public string RelativeTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public RelativeType() { }
    }
}
