using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class BloodTypeRhConfiguration : IEntityTypeConfiguration<BloodRhType>
    {
        public void Configure(EntityTypeBuilder<BloodRhType> builder)
        {
            var data = new List<BloodRhType>();
            data.Add(new BloodRhType() { Id = new Guid("C8444F53-6712-4726-9B86-714B789648BB"), Code = "Rh+", Name = "Rh dương", SortOrder = 1 });
            data.Add(new BloodRhType() { Id = new Guid("0569461C-35A7-46B5-B285-D158B6729DCC"), Code = "Rh-", Name = "Rh âm", SortOrder = 2 });
            builder.HasData(data);
        }
    }
}
