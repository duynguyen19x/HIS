using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Services
{
    public class SurgicalProcedureTypeConfigurations : IEntityTypeConfiguration<SSurgicalProcedureType>
    {
        public void Configure(EntityTypeBuilder<SSurgicalProcedureType> builder)
        {
            builder.ToTable("SSurgicalProcedureTypes");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);
        }
    }
}
