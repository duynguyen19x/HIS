using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class TreatmentRecordConfiguration : IEntityTypeConfiguration<TreatmentRecord>
    {
        public void Configure(EntityTypeBuilder<TreatmentRecord> builder)
        {
            builder.ToTable("TreatmentRecord");
            builder.HasKey(x => x.Id);
        }
    }
}
