using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class MedicalRecordResultConfiguration : IEntityTypeConfiguration<MedicalRecordResult>
    {
        public void Configure(EntityTypeBuilder<MedicalRecordResult> builder)
        {
            builder.ToTable("MedicalRecordResults");
            builder.HasKey(x => x.Id);
        }
    }
}
