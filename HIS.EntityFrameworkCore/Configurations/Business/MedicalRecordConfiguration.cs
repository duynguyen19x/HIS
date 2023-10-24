using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.EntityFrameworkCore.Entities.Business;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class MedicalRecordConfiguration : IEntityTypeConfiguration<MedicalRecord>
    {
        public void Configure(EntityTypeBuilder<MedicalRecord> builder)
        {
            builder.ToTable("MedicalRecord");
            builder.HasKey(x => x.Id);

            //builder.HasOne(x => x.PatientRecordFk).WithMany().HasForeignKey(x => x.PatientRecordID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
