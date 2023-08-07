using HIS.EntityFrameworkCore.Entities.Business.Patients;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Patients
{
    public class PatientConfiguration : IEntityTypeConfiguration<SPatient>
    {
        public void Configure(EntityTypeBuilder<SPatient> builder)
        {
            builder.ToTable("SPatients");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(512);
            builder.Property(x => x.Address).HasMaxLength(512);

            builder.HasOne(t => t.Gender).WithMany(pc => pc.SPatients).HasForeignKey(pc => pc.GenderId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
