using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.ImpMests;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Business.Pharmaceuticals
{
    public class ImpMestMedicineConfigaration : IEntityTypeConfiguration<DImpMestMedicine>
    {
        public void Configure(EntityTypeBuilder<DImpMestMedicine> builder)
        {
            builder.ToTable("DImpMestMedicines");
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.DImMest)
                .WithMany(pc => pc.DImMestMedicines)
                .HasForeignKey(pc => pc.ImpMestId);

            builder.HasOne(e => e.SMedicine)
               .WithMany(e => e.DImpMestMedicines)
               .HasForeignKey(e => e.MedicineId);
        }
    }
}
