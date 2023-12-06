using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    internal class HospitalConfiguration : IEntityTypeConfiguration<Hospital>
    {
        public void Configure(EntityTypeBuilder<Hospital> builder)
        {
            builder.ToTable("Hospitals");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(20).IsRequired(); 
            builder.Property(x => x.MohCode).HasMaxLength(20);
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired(); 
            builder.Property(x => x.Grade).HasMaxLength(50);
            builder.Property(x => x.Line).HasMaxLength(50);
            builder.Property(x => x.Type).HasMaxLength(50);
            builder.Property(x => x.Address).HasMaxLength(512);
            builder.Property(x => x.Description).HasMaxLength(255);
        }
    }
}
