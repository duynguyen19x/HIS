using HIS.Core.Entities;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Tỉnh, thành phố.
    /// </summary>
    public class SProvince : Entity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid? CountryId { get; set; }
        public bool Inactive { get; set; }

        public virtual SCountry Country { get; set; }
        public virtual IList<SDistrict> Districts { get; set; }
    }
}
