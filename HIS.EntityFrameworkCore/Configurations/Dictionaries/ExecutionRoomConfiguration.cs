using HIS.EntityFrameworkCore.Entities.Categories;
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
    public class ExecutionRoomConfiguration : IEntityTypeConfiguration<SExecutionRoom>
    {
        public void Configure(EntityTypeBuilder<SExecutionRoom> builder)
        {
            builder.ToTable("SExecutionRooms");
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.SService).WithMany(pc => pc.SExecutionRooms)
              .HasForeignKey(pc => pc.ServiceId).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.SRoom).WithMany(pc => pc.SExecutionRooms)
              .HasForeignKey(pc => pc.RoomId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
