﻿using HIS.EntityFrameworkCore.Constants;
using HIS.EntityFrameworkCore.Entities.System;
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
                new SYSPermission() { SubSystemId = "SYSUser", Id = "SYSUser", Name= "Sử dụng", SortOrder = 1 },
                new SYSPermission() { SubSystemId = "SYSUser", Id = "SYSUser.Create", Name= "Thêm", SortOrder = 2 },
                new SYSPermission() { SubSystemId = "SYSUser", Id = "SYSUser.Edit", Name= "Sửa", SortOrder = 3 },
                new SYSPermission() { SubSystemId = "SYSUser", Id = "SYSUser.Delete", Name= "Xóa", SortOrder = 4 },
                new SYSPermission() { SubSystemId = "SYSUser", Id = "SYSUser.ExportExcel", Name= "Xuất khẩu excel", SortOrder = 5 },

                new SYSPermission() { SubSystemId = "SYSRole", Id = "SYSRole", Name = "Sử dụng", SortOrder = 1 },
                new SYSPermission() { SubSystemId = "SYSRole", Id = "SYSRole.Create", Name = "Thêm", SortOrder = 2 },
                new SYSPermission() { SubSystemId = "SYSRole", Id = "SYSRole.Edit", Name = "Sửa", SortOrder = 3 },
                new SYSPermission() { SubSystemId = "SYSRole", Id = "SYSRole.Delete", Name = "Xóa", SortOrder = 4 },
                new SYSPermission() { SubSystemId = "SYSRole", Id = "SYSRole.ExportExcel", Name = "Xuất khẩu excel", SortOrder = 5 },

                new SYSPermission() { SubSystemId = "SYSAuditLog", Id = "SYSAuditLog", Name = "Sử dụng", SortOrder = 1 },
                new SYSPermission() { SubSystemId = "SYSAuditLog", Id = "SYSAuditLog.Delete", Name = "Xóa", SortOrder = 2 },
                new SYSPermission() { SubSystemId = "SYSAuditLog", Id = "SYSAuditLog.ExportExcel", Name = "Xuất khẩu excel", SortOrder = 3 },

                new SYSPermission() { SubSystemId = "SYSOption", Id = "SYSOption", Name = "Sử dụng", SortOrder = 90 },
                new SYSPermission() { SubSystemId = "SYSOption", Id = "SYSOption", Name = "Sử dụng", SortOrder = 91 },
                new SYSPermission() { SubSystemId = "SYSOption", Id = "SYSLayoutTemplate", Name = "Sử dụn", SortOrder = 99 }

                );
        }
    }
}