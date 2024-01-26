using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class RoomConfiguration : IEntityTypeConfiguration<DIRoom>
    {
        public void Configure(EntityTypeBuilder<DIRoom> builder)
        {
            builder.ToTable("DIC_Room");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.RoomCode).HasMaxLength(20).IsRequired(); 
            builder.Property(x => x.RoomName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.MediCode).HasMaxLength(20);
            builder.Property(x => x.Description).HasMaxLength(512);
            builder.Property(x => x.RoomTypeID).IsRequired();
            builder.Property(x => x.DepartmentID).IsRequired();

            builder.HasOne(t => t.RoomType).WithMany().HasForeignKey(p => p.RoomTypeID);
            builder.HasOne(t => t.Department).WithMany().HasForeignKey(p => p.DepartmentID);
        }
    }
}
