using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class GenderConfiguration : IEntityTypeConfiguration<DIGender>
    {
        public void Configure(EntityTypeBuilder<DIGender> builder)
        {
            builder.ToTable("DIC_Gender");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasData(
                new DIGender()
                {
                    Id = new Guid("97AC7FD8-EDFA-4243-97FC-98468F492DF1"),
                    Code = "KXD",
                    Name = "Chưa xác định",
                    SortOrder = (int)GenderTypes.None
                },
                new DIGender()
                {
                    Id = new Guid("FC153433-BF89-4E95-8523-DF3D8CEC8676"),
                    Code = "NAM",
                    Name = "Nam",
                    SortOrder = (int)GenderTypes.Male
                },
                new DIGender()
                {
                    Id = new Guid("E9497984-D355-41AF-B917-091500956BE9"),
                    Code = "NU",
                    Name = "Nữ",
                    SortOrder = (int)GenderTypes.Female
                });
        }
    }
}
