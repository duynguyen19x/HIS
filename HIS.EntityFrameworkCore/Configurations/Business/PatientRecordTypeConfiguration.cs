using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.EntityFrameworkCore.Entities.Dictionaries;

namespace HIS.EntityFrameworkCore.Configurations.Business
{
    public class PatientRecordTypeConfiguration : IEntityTypeConfiguration<PatientRecordType>
    {
        public void Configure(EntityTypeBuilder<PatientRecordType> builder)
        {
            builder.ToTable("PatientRecordTypes");
            builder.HasKey(x => x.Id);
        }
    }
}
