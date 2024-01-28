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
    public class SYSRefTypeConfiguration : IEntityTypeConfiguration<SYSRefType>
    {
        public void Configure(EntityTypeBuilder<SYSRefType> builder)
        {
            builder.ToTable("SYSRefType");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id);
            builder.Property(x => x.RefTypeName).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasOne(t => t.RefTypeCategoryFk).WithMany().HasForeignKey(p => p.RefTypeCategoryId);

            builder.HasData(
                new SYSRefType { Id = 101, RefTypeName = "Quản lý người dùng", RefTypeCategoryId = 1, SortOrder = 2 },
                new SYSRefType { Id = 102, RefTypeName = "Loại đối tượng bệnh nhân", RefTypeCategoryId = 1, SortOrder = 3 },
                new SYSRefType { Id = 103, RefTypeName = "Loại đối tượng đăng ký khám", RefTypeCategoryId = 1, SortOrder = 4 },
                new SYSRefType { Id = 104, RefTypeName = "Loại bệnh án", RefTypeCategoryId = 1, SortOrder = 5 },
                new SYSRefType { Id = 199, RefTypeName = "Tùy chọn", RefTypeCategoryId = 1, SortOrder = 9 },

                new SYSRefType { Id = 201, RefTypeName = "Chi nhánh", RefTypeCategoryId = 2, SortOrder = 1 },
                new SYSRefType { Id = 202, RefTypeName = "Khoa", RefTypeCategoryId = 2, SortOrder = 2 },
                new SYSRefType { Id = 203, RefTypeName = "Phòng", RefTypeCategoryId = 2, SortOrder = 3 },
                new SYSRefType { Id = 204, RefTypeName = "Quốc tịch", RefTypeCategoryId = 2, SortOrder = 4 },
                new SYSRefType { Id = 205, RefTypeName = "Tỉnh, thành phố", RefTypeCategoryId = 2, SortOrder = 5 },
                new SYSRefType { Id = 206, RefTypeName = "Quận, huyện", RefTypeCategoryId = 2, SortOrder = 6 },
                new SYSRefType { Id = 207, RefTypeName = "Xã, phường", RefTypeCategoryId = 2, SortOrder = 7 },
                new SYSRefType { Id = 208, RefTypeName = "Dân tộc", RefTypeCategoryId = 2, SortOrder = 8 },
                new SYSRefType { Id = 209, RefTypeName = "Giới tính", RefTypeCategoryId = 2, SortOrder = 9 },
                new SYSRefType { Id = 210, RefTypeName = "Nghề nghiệp", RefTypeCategoryId = 2, SortOrder = 10 },
                new SYSRefType { Id = 211, RefTypeName = "Tôn giáo", RefTypeCategoryId = 2, SortOrder = 11 },
                new SYSRefType { Id = 212, RefTypeName = "Nơi sống", RefTypeCategoryId = 2, SortOrder = 12 },

                new SYSRefType { Id = 301, RefTypeName = "Đón tiếp", RefTypeCategoryId = 3, SortOrder = 1 },

                new SYSRefType { Id = 401, RefTypeName = "Khám bệnh", RefTypeCategoryId = 4, SortOrder = 3 }
                );
        }
    }
}
