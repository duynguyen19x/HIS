using HIS.EntityFrameworkCore.Authorization;
using HIS.EntityFrameworkCore.Configurations.Dictionaries;
using HIS.EntityFrameworkCore.Constants;
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
    public class SYSPermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            var permission = new Permission(PermissionNames.Pages, "HIS", null);

            #region - hệ thống 

            var sytem = permission.CreateChildPermission(PermissionNames.Pages_System, "Hệ thống");

            var user = sytem.CreateChildPermission("SYSUser", "Quản lý người dùng");
            user.CreateChildPermission("SYSUser.Use", "Sử dụng");
            user.CreateChildPermission("SYSUser.Create", "Thêm mới");
            user.CreateChildPermission("SYSUser.Edit", "Sửa");
            user.CreateChildPermission("SYSUser.Delete", "Xóa");

            var role = sytem.CreateChildPermission("SYSRole", "Vai trò và quyền hạn");
            role.CreateChildPermission("SYSRole.Use", "Sử dụng");
            role.CreateChildPermission("SYSRole.Create", "Thêm");
            role.CreateChildPermission("SYSRole.Edit", "Sửa");
            role.CreateChildPermission("SYSRole.Delete", "Xóa");

            var auditingLog = sytem.CreateChildPermission("SYSAuditingLog", "Nhật ký truy cập");
            auditingLog.CreateChildPermission("SYSAuditingLog.Use", "Sử dụng");
            auditingLog.CreateChildPermission("SYSAuditingLog.Delete", "Xóa");
            auditingLog.CreateChildPermission("SYSAuditingLog.ExportExcel", "Xuất khẩu excel");

            var option = sytem.CreateChildPermission("SYSOption", "Tùy chọn");
            option.CreateChildPermission("SYSOptionUser", "Tùy chọn riêng");
            option.CreateChildPermission("SYSOptionGeneral", "Tùy chọn chung");
            option.CreateChildPermission("SYSOptionAutoNumber", "Quy tác đánh số tự động");
            option.CreateChildPermission("SYSOptionNumberFormat", "Định dạng số");
            option.CreateChildPermission("SYSOptionReport", "Báo cáo");

            #endregion

            #region - danh mục

            var dictionary = permission.CreateChildPermission(PermissionNames.Pages_Dictionary, "Danh mục");
            var branch = dictionary.CreateChildPermission("DIBranch", "Chi nhánh");
            branch.CreateChildPermission("DIBranch.Use", "Sử dụng");
            branch.CreateChildPermission("DIBranch.Create", "Thêm mới");
            branch.CreateChildPermission("DIBranch.Edit", "Sửa");
            branch.CreateChildPermission("DIBranch.Delete", "Xóa");

            var department = dictionary.CreateChildPermission("DIdepartment", "Khoa");
            department.CreateChildPermission("DIBranch.Use", "Sử dụng");
            department.CreateChildPermission("DIBranch.Create", "Thêm mới");
            department.CreateChildPermission("DIBranch.Edit", "Sửa");
            department.CreateChildPermission("DIBranch.Delete", "Xóa");

            var room = dictionary.CreateChildPermission("DIRoom", "Phòng");
            room.CreateChildPermission("DIBranch.Use", "Sử dụng");
            room.CreateChildPermission("DIBranch.Create", "Thêm mới");
            room.CreateChildPermission("DIBranch.Edit", "Sửa");
            room.CreateChildPermission("DIBranch.Delete", "Xóa");

            var chamber = dictionary.CreateChildPermission("DIChamber", "Buồng");
            chamber.CreateChildPermission("DIBranch.Use", "Sử dụng");
            chamber.CreateChildPermission("DIBranch.Create", "Thêm mới");
            chamber.CreateChildPermission("DIBranch.Edit", "Sửa");
            chamber.CreateChildPermission("DIBranch.Delete", "Xóa");

            var bed = dictionary.CreateChildPermission("DIBed", "Giường");
            bed.CreateChildPermission("DIBranch.Use", "Sử dụng");
            bed.CreateChildPermission("DIBranch.Create", "Thêm mới");
            bed.CreateChildPermission("DIBranch.Edit", "Sửa");
            bed.CreateChildPermission("DIBranch.Delete", "Xóa");

            #endregion

            #region - nghiệp vụ

            var business = permission.CreateChildPermission(PermissionNames.Pages_Business, "Nghiệp vụ");

            #endregion

            #region - báo cáo

            #endregion
        }
    }
}
