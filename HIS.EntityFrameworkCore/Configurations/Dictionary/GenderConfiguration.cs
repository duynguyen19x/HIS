using HIS.EntityFrameworkCore.Entities;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasData(
                new Gender() { Id = (int)GenderTypes.None,  Code = "KXD", Name = "Chưa xác định", SortOrder = (int)GenderTypes.None, CreatedDate = new DateTime(2024, 1, 1) },
                new Gender() { Id = (int)GenderTypes.Male, Code = "NAM", Name = "Nam", SortOrder = (int)GenderTypes.Male, CreatedDate = new DateTime(2024, 1, 1) },
                new Gender() { Id = (int)GenderTypes.Female, Code = "NU", Name = "Nữ", SortOrder = (int)GenderTypes.Female, CreatedDate = new DateTime(2024, 1, 1) });
        }
    }
}
