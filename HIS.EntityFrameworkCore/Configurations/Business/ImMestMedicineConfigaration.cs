using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.ImpMests;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class ImMestMedicineConfigaration : IEntityTypeConfiguration<DImMestMedicine>
    {
        public void Configure(EntityTypeBuilder<DImMestMedicine> builder)
        {
            builder.ToTable("DImMestMedicines");
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.DImMest).WithMany(pc => pc.DImMestMedicines)
                .HasForeignKey(pc => pc.ImMestId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
