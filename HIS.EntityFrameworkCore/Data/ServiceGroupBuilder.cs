using HIS.EntityFrameworkCore.Entities.Categories;
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
                    Name = "Xét nghiệm huyết học"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "XN-SH",
                    Name = "Xét nghiệm sinh hóa"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "XN-VS",
                    Name = "Xét nghiệm vi sinh"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "XN-NT",
                    Name = "Xét nghiệm nước tiểu"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "XN-DCD",
                    Name = "Dịch chọc dò"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "GB",
                    Name = "Giải phẫu bệnh lý"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "PT",
                    Name = "Phẫu thuật"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "KH",
                    Name = "Khám"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "TDCN-DND",
                    Name = "Điện não đồ"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "TDCN-TTD",
                    Name = "Điện tâm đồ"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "PH",
                    Name = "Phục hồi chức năng"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "TT",
                    Name = "Thủ thuật"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "CDHA-NS",
                    Name = "Nội soi"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "CDHA-XQ",
                    Name = "XQuang thường"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "CDHA-XQ-KTS",
                    Name = "XQuang kỹ thuật số"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "CDHA-MRI",
                    Name = "Cộng hưởng từ"
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
                    Name = "Siêu âm thường"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "CDHA-SA-M",
                    Name = "Siêu âm màu"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "AN",
                    Name = "Suất ăn"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "MA",
                    Name = "Máu"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "VT",
                    Name = "Vật tư"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "TH",
                    Name = "Thuốc"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "GI",
                    Name = "Giường"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "VC",
                    Name = "Vận chuyển"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "CL",
                    Name = "Khác"
                });
        }
    }
}
