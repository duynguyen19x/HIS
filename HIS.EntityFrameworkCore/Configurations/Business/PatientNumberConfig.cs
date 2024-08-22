using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class PatientNumberConfig : IEntityTypeConfiguration<PatientNumber>
    {
        public void Configure(EntityTypeBuilder<PatientNumber> builder)
        {
            builder.ToTable("DPatientNumbers");
            builder.HasKey(x => x.Id);
        }
    }
}
