using HIS.Core.Entities;
using HIS.Core.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Tỉnh, thành phố.
    /// </summary>
    public class Province : AuditedEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid? CountryId { get; set; }
        public bool Inactive { get; set; }

        public virtual Country Country { get; set; }
    }
}
