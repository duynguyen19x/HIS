using HIS.Core.Entities;

namespace HIS.EntityFrameworkCore.Entities.Categories.Services
{
    public class SServiceResultIndice : Entity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal? MaleFrom { get; set; }
        public decimal? MaleTo { get; set; }
        public decimal? FemaleFrom { get; set; }
        public decimal? FemaleTo { get; set; }
        public Guid? ServiceId { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }

        public SService SService { get; set; }
    }
}
