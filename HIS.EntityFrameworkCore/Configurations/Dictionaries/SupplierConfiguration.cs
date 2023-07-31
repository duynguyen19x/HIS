using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.ImpMests;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.EntityFrameworkCore.Entities.Dictionaries;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class SupplierConfiguration
    {
        public void Configure(EntityTypeBuilder<SSupplier> builder)
        {
            builder.ToTable("SSuppliers");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(512);
            builder.Property(x => x.Description).HasMaxLength(512);
        }
    }
}
