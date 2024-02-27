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
    public class SYSPermissionConfiguration : IEntityTypeConfiguration<SYSPermission>
    {
        public void Configure(EntityTypeBuilder<SYSPermission> builder)
        {
            builder.HasData(
                new SYSPermission { Id = 1, Description = "HIS", ParentID = 0, SortOrder = 0 },
                new SYSPermission { Id = 10000, Description = "Hệ thống", ParentID = 1, SortOrder = 1 },
                new SYSPermission { Id = 10100, Description = "Người dùng", ParentID = 10000, SortOrder = 1 },
                new SYSPermission { Id = 10200, Description = "Vai trò và quyền hạn", ParentID = 10000, SortOrder = 2 },
                new SYSPermission { Id = 10300, Description = "Nhật ký truy cập", ParentID = 10000, SortOrder = 3 },
                new SYSPermission { Id = 10400, Description = "Tùy chọn", ParentID = 10000, SortOrder = 4 },

                new SYSPermission { Id = 20000, Description = "Danh mục", ParentID = 1, SortOrder = 2 },
                new SYSPermission { Id = 20100, Description = "Đối tượng", ParentID = 20000, SortOrder = 1 },
                new SYSPermission { Id = 20200, Description = "Cơ cấu tổ chức", ParentID = 20000, SortOrder = 2 },
                new SYSPermission { Id = 20210, Description = "Chi nhánh", ParentID = 20200, SortOrder = 1 },
                new SYSPermission { Id = 20220, Description = "Khoa", ParentID = 20200, SortOrder = 2 },
                new SYSPermission { Id = 20230, Description = "Phòng", ParentID = 20200, SortOrder = 3 },
                new SYSPermission { Id = 20240, Description = "Buồng", ParentID = 20200, SortOrder = 4 },
                new SYSPermission { Id = 20250, Description = "Giường", ParentID = 20200, SortOrder = 5 },

                new SYSPermission { Id = 30000, Description = "Nghiệp vụ", ParentID = 1, SortOrder = 3 },
                new SYSPermission { Id = 30100, Description = "Ngoại trú", ParentID = 30000, SortOrder = 3 },
                new SYSPermission { Id = 30110, Description = "Tiếp đón", ParentID = 30000, SortOrder = 1 },
                new SYSPermission { Id = 30120, Description = "Khám bệnh", ParentID = 30000, SortOrder = 2 },
                new SYSPermission { Id = 30130, Description = "Điều trị ngoại trú", ParentID = 30000, SortOrder = 2 },
                new SYSPermission { Id = 30130, Description = "Mở bệnh án", ParentID = 30000, SortOrder = 2 },

                new SYSPermission { Id = 30200, Description = "Nội trú", ParentID = 30000, SortOrder = 2 },
                new SYSPermission { Id = 30300, Description = "Hành chính", ParentID = 30000, SortOrder = 3 },
                new SYSPermission { Id = 30300, Description = "Điều trị", ParentID = 30000, SortOrder = 3 },
                new SYSPermission { Id = 30300, Description = "Mở bệnh án", ParentID = 30000, SortOrder = 3 },

                new SYSPermission { Id = 30400, Description = "Cận lâm sàng", ParentID = 30000, SortOrder = 3 },
                new SYSPermission { Id = 30400, Description = "Xét nghiệm", ParentID = 30000, SortOrder = 3 },
                new SYSPermission { Id = 30400, Description = "Chẩn đoán hình ảnh", ParentID = 30000, SortOrder = 3 },
                new SYSPermission { Id = 30400, Description = "Dược", ParentID = 30000, SortOrder = 3 },
                new SYSPermission { Id = 30400, Description = "Viện phí", ParentID = 30000, SortOrder = 4 },
                new SYSPermission { Id = 30400, Description = "Bảo hiểm", ParentID = 30000, SortOrder = 4 },

                new SYSPermission { Id = 40000, Description = "Tiện ích", ParentID = 1, SortOrder = 4 },
                new SYSPermission { Id = 40100, Description = "Tìm kiếm bệnh nhân", ParentID = 40000, SortOrder = 4 },

                new SYSPermission { Id = 40000, Description = "Trợ giúp", ParentID = 1, SortOrder = 5 },

                new SYSPermission { Id = 40000, Description = "Báo cáo", ParentID = 1, SortOrder = 6 }
                );
        }
    }
}
