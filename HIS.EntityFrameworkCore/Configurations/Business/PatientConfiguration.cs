using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class PatientConfiguration : IEntityTypeConfiguration<HISPatient>
    {
        public void Configure(EntityTypeBuilder<HISPatient> builder)
        {
            builder.ToTable("Patients");
            builder.HasKey(x => x.Id);
            builder.Property(r => r.Code).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Name).IsRequired().HasMaxLength(500);
            builder.Property(u => u.Description).HasMaxLength(500);
        }
    }
}
