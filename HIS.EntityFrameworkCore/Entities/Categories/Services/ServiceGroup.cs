using HIS.Core.Domain.Entities;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class ServiceGroup : Entity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}
