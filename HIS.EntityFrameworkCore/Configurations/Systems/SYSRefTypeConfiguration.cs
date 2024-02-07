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
            builder.HasData(
                new SYSRefType { Id = 101, Name = "Quản lý người dùng", RefTypeCategoryId = 1, SortOrder = 2 },
                new SYSRefType { Id = 102, Name = "Loại đối tượng bệnh nhân", RefTypeCategoryId = 1, SortOrder = 3 },
                new SYSRefType { Id = 103, Name = "Loại đối tượng đăng ký khám", RefTypeCategoryId = 1, SortOrder = 4 },
                new SYSRefType { Id = 104, Name = "Loại bệnh án", RefTypeCategoryId = 1, SortOrder = 5 },
                new SYSRefType { Id = 199, Name = "Tùy chọn", RefTypeCategoryId = 1, SortOrder = 9 },

                new SYSRefType { Id = 201, Name = "Chi nhánh", RefTypeCategoryId = 2, SortOrder = 1 },
                new SYSRefType { Id = 202, Name = "Khoa", RefTypeCategoryId = 2, SortOrder = 2 },
                new SYSRefType { Id = 203, Name = "Phòng", RefTypeCategoryId = 2, SortOrder = 3 },
                new SYSRefType { Id = 204, Name = "Quốc tịch", RefTypeCategoryId = 2, SortOrder = 4 },
                new SYSRefType { Id = 205, Name = "Tỉnh, thành phố", RefTypeCategoryId = 2, SortOrder = 5 },
                new SYSRefType { Id = 206, Name = "Quận, huyện", RefTypeCategoryId = 2, SortOrder = 6 },
                new SYSRefType { Id = 207, Name = "Xã, phường", RefTypeCategoryId = 2, SortOrder = 7 },
                new SYSRefType { Id = 208, Name = "Dân tộc", RefTypeCategoryId = 2, SortOrder = 8 },
                new SYSRefType { Id = 209, Name = "Giới tính", RefTypeCategoryId = 2, SortOrder = 9 },
                new SYSRefType { Id = 210, Name = "Nghề nghiệp", RefTypeCategoryId = 2, SortOrder = 10 },
                new SYSRefType { Id = 211, Name = "Tôn giáo", RefTypeCategoryId = 2, SortOrder = 11 },
                new SYSRefType { Id = 212, Name = "Nơi sống", RefTypeCategoryId = 2, SortOrder = 12 },

                new SYSRefType { Id = 301, Name = "Đón tiếp", RefTypeCategoryId = 3, SortOrder = 1 },

                new SYSRefType { Id = 401, Name = "Khám bệnh", RefTypeCategoryId = 4, SortOrder = 3 }
                );
        }
    }
}
