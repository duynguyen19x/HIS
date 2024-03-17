using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DIDepartmentConfiguration : IEntityTypeConfiguration<DIDepartment>
    {
        public void Configure(EntityTypeBuilder<DIDepartment> builder)
        {
        }
    }
}
