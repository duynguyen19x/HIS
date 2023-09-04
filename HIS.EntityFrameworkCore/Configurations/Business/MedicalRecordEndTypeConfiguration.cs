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
    public class MedicalRecordEndTypeConfiguration : IEntityTypeConfiguration<MedicalRecordEndType>
    {
        public void Configure(EntityTypeBuilder<MedicalRecordEndType> builder)
        {
            builder.ToTable("MedicalRecordEndTypes");
            builder.HasKey(x => x.Id);
        }
    }
}
