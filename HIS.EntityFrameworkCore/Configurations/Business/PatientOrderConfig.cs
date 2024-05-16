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
    public class PatientOrderConfig : IEntityTypeConfiguration<PatientOrder>
    {
        public void Configure(EntityTypeBuilder<PatientOrder> builder)
        {
            builder.ToTable("DPatientOrder");
            builder.HasKey(x => x.Id);
        }
    }
}
