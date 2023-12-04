using HIS.Core.Entities;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Tỉnh, thành phố.
    /// </summary>
    public class Province : Entity<Guid>
    {
        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}
