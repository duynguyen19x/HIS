using HIS.Core.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Quận, huyện
    /// </summary>
    public class District : AuditedEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public Guid ProvinceId { get; set; }

        public virtual Province Province { get; set; }
    }
}
