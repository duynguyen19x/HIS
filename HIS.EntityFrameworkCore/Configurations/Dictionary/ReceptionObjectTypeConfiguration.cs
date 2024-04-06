using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class ReceptionObjectTypeConfiguration : IEntityTypeConfiguration<ReceptionObjectType>
    {
        public void Configure(EntityTypeBuilder<ReceptionObjectType> builder)
        {
            builder.HasData(
                new ReceptionObjectType((int)ReceptionTypes.KHAMBENH, "Khám bệnh", 1),
                new ReceptionObjectType((int)ReceptionTypes.CAPCUU, "Cấp cứu", 2)
                );
        }
    }
}
