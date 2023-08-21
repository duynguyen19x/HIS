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
    public class PatientRecordConfiguration : IEntityTypeConfiguration<HISPatientRecord>
    {
        public void Configure(EntityTypeBuilder<HISPatientRecord> builder)
        {
            builder.ToTable("PatientRecord");
            builder.HasKey(x => x.Id);
        }
    }
}
