using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    public class InOutStockType : AuditedEntity<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Inactive { get; set; }
    }
}
