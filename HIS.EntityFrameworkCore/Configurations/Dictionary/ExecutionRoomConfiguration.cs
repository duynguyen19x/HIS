using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class ExecutionRoomConfiguration : IEntityTypeConfiguration<ExecutionRoom>
    {
        public void Configure(EntityTypeBuilder<ExecutionRoom> builder)
        {
            builder.ToTable("SExecutionRoom");
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.Service).WithMany()
              .HasForeignKey(pc => pc.ServiceId);

            builder.HasOne(t => t.Room).WithMany()
              .HasForeignKey(pc => pc.RoomId);
        }
    }
}
