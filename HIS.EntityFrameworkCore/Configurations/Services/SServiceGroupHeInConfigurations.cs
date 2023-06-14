using HIS.EntityFrameworkCore.Entities.Categories;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.EntityFrameworkCore.Entities.Categories.Services;

namespace HIS.EntityFrameworkCore.Configurations.Services
{
    public  class SServiceGroupHeInConfigurations : IEntityTypeConfiguration<SServiceGroupHeIn>
    {
        public void Configure(EntityTypeBuilder<SServiceGroupHeIn> builder)
        {
            builder.ToTable("SServiceGroupHeIns");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(500);
        }
    }
}
