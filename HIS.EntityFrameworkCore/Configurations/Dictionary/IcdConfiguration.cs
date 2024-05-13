using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    internal class IcdConfiguration : IEntityTypeConfiguration<Icd>
    {
        public void Configure(EntityTypeBuilder<Icd> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            builder.Property(x => x.MohReportCode).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired();
            builder.Property(x => x.NameEnglish).HasMaxLength(512);
            builder.Property(x => x.NameCommon).HasMaxLength(512);

            builder.Property(x => x.ChapterCode).HasMaxLength(50);
            builder.Property(x => x.ChapterName).HasMaxLength(512);
            builder.Property(x => x.ChapterNameEnglish).HasMaxLength(512);

            builder.Property(x => x.MainGroupCode).HasMaxLength(50);
            builder.Property(x => x.MainGroupName).HasMaxLength(512);
            builder.Property(x => x.MainGroupNameEnglish).HasMaxLength(512);

            builder.Property(x => x.SubGroup1Code).HasMaxLength(50);
            builder.Property(x => x.SubGroup1Name).HasMaxLength(512);
            builder.Property(x => x.SubGroup1NameEnglish).HasMaxLength(512);

            builder.Property(x => x.SubGroup2Code).HasMaxLength(50);
            builder.Property(x => x.SubGroup2Name).HasMaxLength(512);
            builder.Property(x => x.SubGroup2NameEnglish).HasMaxLength(512);

            builder.Property(x => x.TypeCode).HasMaxLength(50);
            builder.Property(x => x.TypeName).HasMaxLength(512);
            builder.Property(x => x.TypeNameEnglish).HasMaxLength(512);

            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasOne(t => t.ChapterIcd).WithMany()
              .HasForeignKey(pc => pc.ChapterIcdId);
        }
    }
}
