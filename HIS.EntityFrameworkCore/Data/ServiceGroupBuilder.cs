using HIS.EntityFrameworkCore.Entities.Categories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data
{
    public static class ServiceGroupBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SServiceGroup>().HasData(
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "XN-HH",
                    Name = "Xét nghiệm huyết học",
                    SortOrder = 1
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "XN-SH",
                    Name = "Xét nghiệm sinh hóa",
                    SortOrder = 2
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "XN-VS",
                    Name = "Xét nghiệm vi sinh",
                    SortOrder = 3
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "XN-NT",
                    Name = "Xét nghiệm nước tiểu",
                    SortOrder = 4
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "XN-DCD",
                    Name = "Dịch chọc dò",
                    SortOrder = 5
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "GB",
                    Name = "Giải phẫu bệnh lý",
                    SortOrder = 6
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "PT",
                    Name = "Phẫu thuật",
                    SortOrder = 7
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "KH",
                    Name = "Khám",
                    SortOrder = 8
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "TDCN-DND",
                    Name = "Điện não đồ",
                    SortOrder = 9
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "TDCN-TTD",
                    Name = "Điện tâm đồ",
                    SortOrder = 10
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "PH",
                    Name = "Phục hồi chức năng",
                    SortOrder = 11
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "TT",
                    Name = "Thủ thuật",
                    SortOrder = 12
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "CDHA-NS",
                    Name = "Nội soi",
                    SortOrder = 13
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "CDHA-XQ",
                    Name = "XQuang thường",
                    SortOrder = 14
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "CDHA-XQ-KTS",
                    Name = "XQuang kỹ thuật số",
                    SortOrder = 15
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "CDHA-MRI",
                    Name = "Cộng hưởng từ",
                    SortOrder = 16
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "CDHA-CT",
                    Name = "Cắt lớp vi tính"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "CDHA-SA",
                    Name = "Siêu âm thường",
                    SortOrder = 17
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "CDHA-SA-M",
                    Name = "Siêu âm màu",
                    SortOrder = 18
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "AN",
                    Name = "Suất ăn",
                    SortOrder = 19
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "MA",
                    Name = "Máu",
                    SortOrder = 20
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "VT",
                    Name = "Vật tư",
                    SortOrder = 21
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "TH",
                    Name = "Thuốc",
                    SortOrder = 22
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "GI",
                    Name = "Giường",
                    SortOrder = 23
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "VC",
                    Name = "Vận chuyển",
                    SortOrder = 24
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "CL",
                    Name = "Khác",
                    SortOrder = 25
                });
        }
    }
}
