using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Business.Pharmaceuticals
{
    public class ImpExpMestTypeConfiguration : IEntityTypeConfiguration<DImpExpMestType>
    {
        public void Configure(EntityTypeBuilder<DImpExpMestType> builder)
        {
            builder.ToTable("DImpExpMestTypes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Code).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(512);
        }
    }
}
