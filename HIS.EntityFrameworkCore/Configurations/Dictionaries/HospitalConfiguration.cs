using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    internal class HospitalConfiguration : IEntityTypeConfiguration<SHospital>
    {
        public void Configure(EntityTypeBuilder<SHospital> builder)
        {
            builder.ToTable("SHospitals");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.MohCode).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(512);
            builder.Property(x => x.Grade).HasMaxLength(50);
            builder.Property(x => x.Line).HasMaxLength(50);
            builder.Property(x => x.Address).HasMaxLength(512);
            builder.Property(x => x.Description).HasMaxLength(512);
        }
    }
}
