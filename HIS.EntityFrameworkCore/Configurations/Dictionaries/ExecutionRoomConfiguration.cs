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
    public class ExecutionRoomConfiguration : IEntityTypeConfiguration<ExecutionRoom>
    {
        public void Configure(EntityTypeBuilder<ExecutionRoom> builder)
        {
            builder.ToTable("ExecutionRooms");
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.Service).WithMany()
              .HasForeignKey(pc => pc.ServiceId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.Room).WithMany()
              .HasForeignKey(pc => pc.RoomId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
