using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DITreatmentEndTypeConfiguration : IEntityTypeConfiguration<DITreatmentEndType>
    {
        public void Configure(EntityTypeBuilder<DITreatmentEndType> builder)
        {
        }
    }
}
