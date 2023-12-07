using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class MedicalRecordConfiguration : IEntityTypeConfiguration<MedicalRecord>
    {
        public void Configure(EntityTypeBuilder<MedicalRecord> builder)
        {
            builder.ToTable("BUS_MedicalRecord");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.MedicalRecordCode).HasMaxLength(50);
            builder.Property(x => x.InIcdCode).HasMaxLength(50);
            builder.Property(x => x.InIcdName).HasMaxLength(512);
            builder.Property(x => x.InIcdSubCode).HasMaxLength(50);
            builder.Property(x => x.InIcdText).HasMaxLength(512);     
            builder.Property(x => x.InTraditionalIcdCode).HasMaxLength(50);
            builder.Property(x => x.InTraditionalIcdName).HasMaxLength(512);   
            builder.Property(x => x.InTraditionalIcdSubCode).HasMaxLength(50);
            builder.Property(x => x.InTraditionalIcdText).HasMaxLength(512);        
            builder.Property(x => x.IcdCode).HasMaxLength(50);
            builder.Property(x => x.IcdName).HasMaxLength(512);
            builder.Property(x => x.IcdSubCode).HasMaxLength(50);
            builder.Property(x => x.IcdText).HasMaxLength(512);  
            builder.Property(x => x.TraditionalIcdCode).HasMaxLength(50);
            builder.Property(x => x.TraditionalIcdName).HasMaxLength(512);    
            builder.Property(x => x.TraditionalIcdSubCode).HasMaxLength(50);
            builder.Property(x => x.TraditionalIcdText).HasMaxLength(512);

            builder.Property(x => x.MedicalRecordDate);
        }
    }
}
