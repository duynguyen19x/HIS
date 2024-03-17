using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DIDistrictConfiguration : IEntityTypeConfiguration<DIDistrict>
    {
        public void Configure(EntityTypeBuilder<DIDistrict> builder)
        {
        }
    }
}
