using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionary
{
    public class ReceptionObjectTypeConfiguration : IEntityTypeConfiguration<ReceptionObjectType>
    {
        public void Configure(EntityTypeBuilder<ReceptionObjectType> builder)
        {
            builder.HasData(
                new ReceptionObjectType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DIReceptionObjectType.KHAMBENH , Code = "01", Name = "Khám bệnh", SortOrder = 1 },
                new ReceptionObjectType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DIReceptionObjectType.CAPCUU, Code = "02", Name = "Cấp cứu", SortOrder = 2 }
                );
        }
    }
}
