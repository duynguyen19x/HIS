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
    public class ExaminationConfig : IEntityTypeConfiguration<Examination>
    {
        public void Configure(EntityTypeBuilder<Examination> builder)
        {
            builder.ToTable("DExamination");
            builder.HasKey(x => x.Id);
        }
    }
}
