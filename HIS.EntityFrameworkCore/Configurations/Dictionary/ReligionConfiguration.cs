using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class ReligionConfiguration : IEntityTypeConfiguration<Religion>
    {
        public void Configure(EntityTypeBuilder<Religion> builder)
        {
            //builder.ToTable("DIC_Religion");
            //builder.HasKey(x => x.Id);
            //builder.Property(x => x.Code).HasMaxLength(20).IsRequired();
            //builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
            //builder.Property(x => x.Description).HasMaxLength(255);

            
        }
    }
}
