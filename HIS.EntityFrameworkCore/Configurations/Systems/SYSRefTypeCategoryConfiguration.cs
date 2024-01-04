using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Systems
{
    public class SYSRefTypeCategoryConfiguration : IEntityTypeConfiguration<SYSRefTypeCategory>
    {
        public void Configure(EntityTypeBuilder<SYSRefTypeCategory> builder)
        {
            builder.ToTable("SYSRefTypeCategory");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.RefTypeCategoryName).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(255);


            builder.HasData(
                new SYSRefTypeCategory { Id = 1, RefTypeCategoryName = "Hệ thống", Description = "Các chức năng quản lý và xử lý hệ thống", SortOrder = 1 },
                new SYSRefTypeCategory { Id = 2, RefTypeCategoryName = "Danh mục", Description = "Các chức năng người dùng khai báo", SortOrder = 2 },
                new SYSRefTypeCategory { Id = 3, RefTypeCategoryName = "Đón tiếp", Description = "Các chức năng tiếp đón", SortOrder = 3 },
                new SYSRefTypeCategory { Id = 4, RefTypeCategoryName = "Khám bệnh", Description = "Các chức năng khám bệnh", SortOrder = 4 },
                new SYSRefTypeCategory { Id = 99, RefTypeCategoryName = "Khác", Description = "Khác", SortOrder = 99 }
                );
        }
    }
}
