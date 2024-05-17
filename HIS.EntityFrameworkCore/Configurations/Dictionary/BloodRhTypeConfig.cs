using HIS.EntityFrameworkCore.Constants;
using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class BloodRhTypeConfig : IEntityTypeConfiguration<BloodRhType>
    {
        public void Configure(EntityTypeBuilder<BloodRhType> builder)
        {
            builder.ToTable("SBloodRhType");

            builder.Property(x => x.BloodRhTypeCode).HasMaxLength(BloodRhTypeConst.BloodRhTypeCodeLength).IsRequired();
            builder.Property(x => x.BloodRhTypeName).HasMaxLength(BloodRhTypeConst.BloodRhTypeNameLength).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(BloodRhTypeConst.DescriptionLength).IsRequired();

            var data = new List<BloodRhType>();
            data.Add(new BloodRhType() { Id = new Guid("C8444F53-6712-4726-9B86-714B789648BB"), BloodRhTypeCode = "Rh+", BloodRhTypeName = "Rh dương", SortOrder = 1 });
            data.Add(new BloodRhType() { Id = new Guid("0569461C-35A7-46B5-B285-D158B6729DCC"), BloodRhTypeCode = "Rh-", BloodRhTypeName = "Rh âm", SortOrder = 2 });
            builder.HasData(data);
        }
    }
}
