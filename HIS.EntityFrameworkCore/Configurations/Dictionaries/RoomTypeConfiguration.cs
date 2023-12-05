using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.ToTable("RoomType");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.RoomTypeCode).HasMaxLength(20).IsRequired(); 
            builder.Property(x => x.RoomTypeName).HasMaxLength(255).IsRequired(); 
            builder.Property(x => x.Description).HasMaxLength(512);
        }
    }
}
