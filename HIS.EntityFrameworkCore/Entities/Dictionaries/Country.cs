using HIS.Core.Entities;
using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Categories;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Quốc gia.
    /// </summary>
    public class Country : AuditedEntity<Guid>
    {
        public string Code { get; set; }
        public string HeInCode { get; set; }
        public string Name { get; set; }
        public bool Inactive { get; set; }
    }
}
