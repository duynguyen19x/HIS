using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.ImpMests;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.ExpMests;

namespace HIS.EntityFrameworkCore.Configurations.Business.Pharmaceuticals
{
    public class DExpMestMedicineConfiguration : IEntityTypeConfiguration<DExpMestMedicine>
    {
        public void Configure(EntityTypeBuilder<DExpMestMedicine> builder)
        {
            builder.ToTable("DExpMestMedicines");
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.DExpMest)
                .WithMany()
                .HasForeignKey(t => t.ExpMestId);

            builder.HasOne(e => e.SMedicine)
               .WithMany()
               .HasForeignKey(e => e.MedicineId);
        }
    }
}
