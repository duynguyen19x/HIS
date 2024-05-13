using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class BloodTypeConfiguration : IEntityTypeConfiguration<BloodType>
    {
        public void Configure(EntityTypeBuilder<BloodType> builder)
        {
            var data = new List<BloodType>();
            data.Add(new BloodType() { Id = new Guid("96FC1F86-2E95-4AAC-BB4B-BD5EB2EF09FE"), Code = "O", Name = "Nhóm máu O", SortOrder = 1 });
            data.Add(new BloodType() { Id = new Guid("BE2CD126-228C-4FBF-9470-C5CB8195465B"), Code = "A", Name = "Nhóm máu A", SortOrder = 2 });
            data.Add(new BloodType() { Id = new Guid("29A04857-F834-4F4A-896B-DB0A829125C4"), Code = "B", Name = "Nhóm máu B", SortOrder = 3 });
            data.Add(new BloodType() { Id = new Guid("B5CE25E2-95A5-4A2F-AC25-B886EE18E56E"), Code = "AB", Name = "Nhóm máu AB", SortOrder = 4 });
            builder.HasData(data);
        }
    }
}
