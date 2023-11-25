using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Core.Extensions;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class ReligionConfiguration : IEntityTypeConfiguration<Religion>
    {
        public void Configure(EntityTypeBuilder<Religion> builder)
        {
            builder.ToTable("Religion");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ReligionCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.ReligionName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasData(
                new Religion { Id = new Guid("D480AD5B-3CC3-4C87-8914-BAD32C6BC04A"), ReligionCode = "0", ReligionName = "Không tôn giáo", SortOrder = 1, CreatedDate = SqlDateTimeExtensions.MinValue },
                new Religion { Id = new Guid("2D9B484C-A190-4288-A337-A35FB5345B9E"), ReligionCode = "1", ReligionName = "Phật Giáo", SortOrder = 2, CreatedDate = SqlDateTimeExtensions.MinValue },
                new Religion { Id = new Guid("BFEA8C9A-7D0F-456B-B226-3DC17E230E8C"), ReligionCode = "2", ReligionName = "Công giáo", SortOrder = 3, CreatedDate = SqlDateTimeExtensions.MinValue },
                new Religion { Id = new Guid("2AD4C6C6-D381-443B-8892-5E39B945DE0F"), ReligionCode = "3", ReligionName = "Phật Giáo Hòa Hảo", SortOrder = 4, CreatedDate = SqlDateTimeExtensions.MinValue },
                new Religion { Id = new Guid("A2690804-6608-4A5A-9FC8-5268B211086C"), ReligionCode = "4", ReligionName = "Cơ đốc giao La Mã", SortOrder = 5, CreatedDate = SqlDateTimeExtensions.MinValue },
                new Religion { Id = new Guid("E72B5425-AAC6-4226-9B4D-F8202B3AD47F"), ReligionCode = "5", ReligionName = "Cao Đài", SortOrder = 6, CreatedDate = SqlDateTimeExtensions.MinValue },
                new Religion { Id = new Guid("84C8B191-8825-41F3-9A8B-AC73BC7B437B"), ReligionCode = "6", ReligionName = "Tin Lành", SortOrder = 7, CreatedDate = SqlDateTimeExtensions.MinValue },
                new Religion { Id = new Guid("E105DD3E-9F3D-4E10-8EDA-E49F8631EEC7"), ReligionCode = "99", ReligionName = "Tôn giáo khác", SortOrder = 99, CreatedDate = SqlDateTimeExtensions.MinValue }
                );
        }
    }
}
