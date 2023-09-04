using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class InOutStockTypeConfiguration : IEntityTypeConfiguration<InOutStockType>
    {
        public void Configure(EntityTypeBuilder<InOutStockType> builder)
        {
            builder.ToTable("InOutStockTypes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(512);
        }
    }
}
