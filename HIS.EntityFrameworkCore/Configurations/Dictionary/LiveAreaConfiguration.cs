using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class LiveAreaConfiguration : IEntityTypeConfiguration<LiveArea>
    {
        public void Configure(EntityTypeBuilder<LiveArea> builder)
        {
            //builder.ToTable("DIC_LiveArea");

            //builder.HasKey(x => x.Id);
            //builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            //builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
            //builder.Property(x => x.MohCode).HasMaxLength(50).IsRequired();
            //builder.Property(x => x.Description).HasMaxLength(255);

            var data = new List<LiveArea>();
            data.Add(new LiveArea() { Id = new Guid("B3EB4635-31FF-4E3F-B55F-A02150017BD7"), Code = "K1", MediCode = "K1", Name = "K1", SortOrder = 1 });
            data.Add(new LiveArea() { Id = new Guid("DDB7F2CD-BE11-495B-80C0-51295E2066B9"), Code = "K2", MediCode = "K2", Name = "K2", SortOrder = 2 });
            data.Add(new LiveArea() { Id = new Guid("0A14BAE0-EEB9-48B3-B49E-B3BB5B1492B1"), Code = "K3", MediCode = "K3", Name = "K3", SortOrder = 3 });
            builder.HasData(data);
        }
    }
}
