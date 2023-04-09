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
        }
    }
}
