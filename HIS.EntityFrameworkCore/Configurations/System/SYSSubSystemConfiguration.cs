using HIS.EntityFrameworkCore.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.System
{
    public class SYSSubSystemConfiguration : IEntityTypeConfiguration<SYSSubSystem>
    {
        public void Configure(EntityTypeBuilder<SYSSubSystem> builder)
        {
            var data = new List<SYSSubSystem>
            {
                new SYSSubSystem() { Id = "SYS", Name = "Hệ thống" },
                new SYSSubSystem() { ParentId = "SYS", Id = "SYSUser", Name = "Quản lý người dùng" },
                new SYSSubSystem() { ParentId = "SYS", Id = "SYSRole", Name = "Vai trò và quyền hạn" },
                new SYSSubSystem() { ParentId = "SYS", Id = "SYSAuditLog", Name = "Nhật ký truy cập" },
                new SYSSubSystem() { ParentId = "SYS", Id = "SYSOption", Name = "Tùy chọn" },
                new SYSSubSystem() { ParentId = "SYS", Id = "SYSLayoutTemplate", Name = "Tùy chọn mẫu hiển thị" },

                new SYSSubSystem() { Id = "DI", Name = "Danh mục" },
                new SYSSubSystem() { ParentId = "DI", Id = "DIOrganizationUnit", Name = "Cơ cấu tổ chức" },
                new SYSSubSystem() { ParentId = "DIOrganizationUnit", Id = "DIBranch", Name = "Chi nhánh" },
                new SYSSubSystem() { ParentId = "DIOrganizationUnit", Id = "DIDepartment", Name = "Khoa" },
                new SYSSubSystem() { ParentId = "DIOrganizationUnit", Id = "DIRoom", Name = "Phòng" },
                new SYSSubSystem() { ParentId = "DIOrganizationUnit", Id = "DIChamber", Name = "Buồng" },
                new SYSSubSystem() { ParentId = "DIOrganizationUnit", Id = "DIBed", Name = "Giường" },

                new SYSSubSystem() { ParentId = "DI", Id = "DICountry", Name = "Quốc tịch"  },
                new SYSSubSystem() { Id = "DIProvince", Name = "Tỉnh, thành phố", ParentId = "DI" },
                new SYSSubSystem() { Id = "DIDistrict", Name = "Quận, huyện", ParentId = "DI" },
                new SYSSubSystem() { Id = "DIWard", Name = "Xã, phường", ParentId = "DI" },
                new SYSSubSystem() { Id = "DIHospital", Name = "Bệnh viện", ParentId = "DI" },
                new SYSSubSystem() { Id = "DIEmployee", Name = "Nhân viên", ParentId = "DI" },
                new SYSSubSystem() { Id = "DIIcd", Name = "Mã bệnh", ParentId = "DI" },
                new SYSSubSystem() { Id = "DIGender", Name = "Giới tính", ParentId = "DI" },
                new SYSSubSystem() { Id = "DIEthnicity", Name = "Dân tộc", ParentId = "DI" },
                new SYSSubSystem() { Id = "DIReligion", Name = "Tôn giáo", ParentId = "DI" },
                new SYSSubSystem() { Id = "DIOther", Name = "Khác", ParentId = "DI" },

                new SYSSubSystem() { Id = "BU", Name = "Nghiệp vụ" },
                new SYSSubSystem() { Id = "BUReception", Name = "Đón tiếp", ParentId = "BU" },
                new SYSSubSystem() { Id = "BUClinical", Name = "Phòng khám", ParentId = "BU" },
                new SYSSubSystem() { Id = "BUPayment", Name = "Viện phí", ParentId = "BU" },

                new SYSSubSystem() { Id = "TU", Name = "Tiện ích" },
                new SYSSubSystem() { Id = "TUSearch", Name = "Tìm kiếm bệnh nhân", ParentId = "TU" },

                new SYSSubSystem() { Id = "RP", Name = "Báo cáo", SortOrder = 5 }
            };

            builder.HasData(data);
        }
    }
}
