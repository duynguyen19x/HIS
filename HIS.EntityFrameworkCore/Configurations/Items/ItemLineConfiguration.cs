using HIS.EntityFrameworkCore.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations
{
    public class ItemLineConfiguration : IEntityTypeConfiguration<ItemLine>
    {
        public void Configure(EntityTypeBuilder<ItemLine> builder)
        {
            builder.ToTable("ItemLines");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);
        }
    }
}
