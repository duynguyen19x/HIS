using HIS.Core.Entities;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    public class InOutStockType : Entity<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Inactive { get; set; }
    }
}
