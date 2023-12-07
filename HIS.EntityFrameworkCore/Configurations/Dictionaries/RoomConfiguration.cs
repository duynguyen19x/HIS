using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("DIC_Room");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.RoomCode).HasMaxLength(20).IsRequired(); 
            builder.Property(x => x.RoomName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.MohCode).HasMaxLength(20);
            builder.Property(x => x.Description).HasMaxLength(512);
            builder.Property(x => x.RoomTypeId).IsRequired();
            builder.Property(x => x.DepartmentId).IsRequired();

            builder.HasOne(t => t.RoomType).WithMany().HasForeignKey(p => p.RoomTypeId);
            builder.HasOne(t => t.Department).WithMany().HasForeignKey(p => p.DepartmentId);
        }
    }
}
