using HIS.EntityFrameworkCore.Constants;
using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class BloodTypeConfig : IEntityTypeConfiguration<BloodType>
    {
        public void Configure(EntityTypeBuilder<BloodType> builder)
        {
            builder.ToTable("SBloodTypes");

            builder.Property(x => x.BloodTypeCode).HasMaxLength(BloodTypeConst.BloodTypeCodeLength).IsRequired();
            builder.Property(x => x.BloodTypeName).HasMaxLength(BloodTypeConst.BloodTypeNameLength).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(BloodTypeConst.DescriptionLength);

            var data = new List<BloodType>();
            data.Add(new BloodType() { Id = new Guid("96FC1F86-2E95-4AAC-BB4B-BD5EB2EF09FE"), BloodTypeCode = "O", BloodTypeName = "Nhóm máu O", SortOrder = 1, CreatedDate = new DateTime(2024, 1, 1) });
            data.Add(new BloodType() { Id = new Guid("BE2CD126-228C-4FBF-9470-C5CB8195465B"), BloodTypeCode = "A", BloodTypeName = "Nhóm máu A", SortOrder = 2, CreatedDate = new DateTime(2024, 1, 1) });
            data.Add(new BloodType() { Id = new Guid("29A04857-F834-4F4A-896B-DB0A829125C4"), BloodTypeCode = "B", BloodTypeName = "Nhóm máu B", SortOrder = 3, CreatedDate = new DateTime(2024, 1, 1) });
            data.Add(new BloodType() { Id = new Guid("B5CE25E2-95A5-4A2F-AC25-B886EE18E56E"), BloodTypeCode = "AB", BloodTypeName = "Nhóm máu AB", SortOrder = 4, CreatedDate = new DateTime(2024, 1, 1) });
            builder.HasData(data);
        }
    }
}
