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
    public class RoomTypeConfiguration : IEntityTypeConfiguration<SRoomType>
    {
        public void Configure(EntityTypeBuilder<SRoomType> builder)
        {
            builder.ToTable("SRoomTypes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired(); ;
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired(); ;
            builder.Property(x => x.Description).HasMaxLength(512);
        }
    }
}
