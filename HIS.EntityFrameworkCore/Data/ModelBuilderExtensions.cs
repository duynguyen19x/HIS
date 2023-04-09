using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Patients;
using HIS.Utilities.Commons;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SUser>().HasData(new SUser()
            {
                Id = Guid.NewGuid(),
                UserName = "Administrator",
                Password = Security.EncryptMd5("Ihs123456a@"),
                FirstName = "Admin",
                LastName = "Administrator",
                Email = "administrator@gmail.com",
                UseType = Utilities.Enums.UseTypes.Admin,
                Status = Utilities.Enums.UserStatusTypes.Active,
            });

            modelBuilder.Entity<SGender>().HasData(
                new SGender()
                {
                    Id = Guid.NewGuid(),
                    Code = Utilities.Enums.GenderTypes.None,
                    Name = "Chưa xác định"
                },
                new SGender()
                {
                    Id = Guid.NewGuid(),
                    Code = Utilities.Enums.GenderTypes.Male,
                    Name = "Nam"
                },
                new SGender()
                {
                    Id = Guid.NewGuid(),
                    Code = Utilities.Enums.GenderTypes.Female,
                    Name = "Nữ"
                });

            modelBuilder.Entity<SServiceGroup>().HasData(
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
                    Code = "CN",
                    Name = "Thăm dò chức năng"
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
                    Code = "NS",
                    Name = "Nội soi"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "HA",
                    Name = "Chẩn đoán hình ảnh"
                },
                new SServiceGroup()
                {
                    Id = Guid.NewGuid(),
                    Code = "XN",
                    Name = "Xét nghiệm"
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
                    Code = "SA",
                    Name = "Siêu âm"
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
                    Code = "CL",
                    Name = "Khác"
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
                });

            modelBuilder.Entity<SPatientType>().HasData(
                new SPatientType()
                {
                    Id = Guid.NewGuid(),
                    Code = "BHYT",
                    Name = "Bảo hiểm y tế",
                    IsActive = true,
                },
                new SPatientType()
                {
                    Id = Guid.NewGuid(),
                    Code = "VP",
                    Name = "Viện phí",
                    IsActive = true,
                },
                new SPatientType()
                {
                    Id = Guid.NewGuid(),
                    Code = "DV",
                    Name = "Dịch vụ",
                    IsActive = true,
                }
            );
        }
    }
}
