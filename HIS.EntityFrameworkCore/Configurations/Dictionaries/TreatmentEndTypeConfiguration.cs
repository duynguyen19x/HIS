using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class TreatmentEndTypeConfiguration : IEntityTypeConfiguration<TreatmentEndType>
    {
        public void Configure(EntityTypeBuilder<TreatmentEndType> builder)
        {
            builder.ToTable("TreatmentEndType");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.TreatmentEndTypeCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.TreatmentEndTypeName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

        }
    }
}
