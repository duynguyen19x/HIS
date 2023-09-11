using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class ReceptionTypeConfiguration : IEntityTypeConfiguration<ReceptionType>
    {
        public void Configure(EntityTypeBuilder<ReceptionType> builder)
        {
            builder.ToTable("ReceptionType");
            builder.HasKey(x => x.Id);
        }
    }
}
