using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class PatientRecordConfiguration : IEntityTypeConfiguration<PatientRecord>
    {
        public void Configure(EntityTypeBuilder<PatientRecord> builder)
        {
            builder.ToTable("PatientRecord");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(20).IsRequired();
            builder.HasOne(x => x.Patient).WithMany().HasForeignKey(x => x.PatientId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
