using HIS.Core.Entities;

namespace HIS.EntityFrameworkCore.Entities.Categories.Services
{
    public class SServiceGroupHeIn : Entity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }

        public List<SService> SServices { get; set; }
    }
}
