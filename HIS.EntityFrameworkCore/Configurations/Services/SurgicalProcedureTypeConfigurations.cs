using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HIS.EntityFrameworkCore.Configurations.Services
{
    public class SurgicalProcedureTypeConfigurations : IEntityTypeConfiguration<SurgicalProcedureType>
    {
        public void Configure(EntityTypeBuilder<SurgicalProcedureType> builder)
        {
            builder.ToTable("SSurgicalProcedureTypes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);

            builder.HasData(
                    new SurgicalProcedureType()
                    {
                        Id = (int)SurgicalProcedureTypes.SpecialSurgery,
                        Code = "PTDB",
                        Name = "Phẫu thuật đặc biệt",
                        SortOrder = (int)SurgicalProcedureTypes.SpecialSurgery
                    },
                    new SurgicalProcedureType()
                    {
                        Id = (int)SurgicalProcedureTypes.TypeSurgery1,
                        Code = "PT01",
                        Name = "Phẫu thuật loại 1",
                        SortOrder = (int)SurgicalProcedureTypes.TypeSurgery1
                    },
                    new SurgicalProcedureType()
                    {
                        Id = (int)SurgicalProcedureTypes.TypeSurgery2,
                        Code = "PT02",
                        Name = "Phẫu thuật loại 2",
                        SortOrder = (int)SurgicalProcedureTypes.TypeSurgery2
                    },
                    new SurgicalProcedureType()
                    {
                        Id = (int)SurgicalProcedureTypes.TypeSurgery3,
                        Code = "PT03",
                        Name = "Phẫu thuật loại 3",
                        SortOrder = (int)SurgicalProcedureTypes.TypeSurgery3
                    }, new SurgicalProcedureType()
                    {
                        Id = (int)SurgicalProcedureTypes.SpecialTrick,
                        Code = "TTDB",
                        Name = "Thủ thuật đặc biệt",
                        SortOrder = (int)SurgicalProcedureTypes.SpecialTrick
                    },
                    new SurgicalProcedureType()
                    {
                        Id = (int)SurgicalProcedureTypes.TypeTrick1,
                        Code = "TT01",
                        Name = "Thủ thuật loại 1",
                        SortOrder = (int)SurgicalProcedureTypes.TypeTrick1
                    },
                    new SurgicalProcedureType()
                    {
                        Id = (int)SurgicalProcedureTypes.TypeTrick2,
                        Code = "TT02",
                        Name = "Thủ thuật loại 2",
                        SortOrder = (int)SurgicalProcedureTypes.TypeTrick2
                    },
                    new SurgicalProcedureType()
                    {
                        Id = (int)SurgicalProcedureTypes.TypeTrick3,
                        Code = "TT03",
                        Name = "Thủ thuật loại 3",
                        SortOrder = (int)SurgicalProcedureTypes.TypeTrick3
                    });
        }
    }
}
