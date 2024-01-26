using HIS.Core.Domain.Entities;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Quốc tịch.
    /// </summary>
    public class DICountry : Entity<Guid>
    {
        public string CountryCode { get; set; }

        public string CountryName { get; set; }

        public string MediCode { get; set; }

        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }
    }
}
