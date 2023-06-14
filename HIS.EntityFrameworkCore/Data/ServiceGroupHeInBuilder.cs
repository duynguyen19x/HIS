using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data
{
    public static class ServiceGroupHeInBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SServiceGroupHeIn>().HasData(
                new SServiceGroupHeIn()
                {
                    Id = Guid.NewGuid(),
                    Code = "1",
                    Name = "Xét nghiệm",
                    SortOrder = 1
                },
                new SServiceGroupHeIn()
                {
                    Id = Guid.NewGuid(),
                    Code = "2",
                    Name = "Chẩn đoán hình ảnh",
                    SortOrder = 2
                },
                new SServiceGroupHeIn()
                {
                    Id = Guid.NewGuid(),
                    Code = "3",
                    Name = "Thăm dò chức năng",
                    SortOrder = 3
                },
                new SServiceGroupHeIn()
                {
                    Id = Guid.NewGuid(),
                    Code = "4",
                    Name = "Thuốc trong danh mục BHYT",
                    SortOrder = 4
                },
                new SServiceGroupHeIn()
                {
                    Id = Guid.NewGuid(),
                    Code = "5",
                    Name = "Thuốc điều trị ung thư, chống thải ghép ngoài danh mục",
                    SortOrder = 5
                },
                new SServiceGroupHeIn()
                {
                    Id = Guid.NewGuid(),
                    Code = "6",
                    Name = "Thuốc thanh toán theo tỷ lệ",
                    SortOrder = 6
                },
                new SServiceGroupHeIn()
                {
                    Id = Guid.NewGuid(),
                    Code = "7",
                    Name = "Máu và chế phẩm máu",
                    SortOrder = 7
                },
                new SServiceGroupHeIn()
                {
                    Id = Guid.NewGuid(),
                    Code = "8",
                    Name = "Phẫu thuật",
                    SortOrder = 8
                },
                new SServiceGroupHeIn()
                {
                    Id = Guid.NewGuid(),
                    Code = "9",
                    Name = "DVKT thanh toán theo tỷ lệ",
                    SortOrder = 9
                },
                new SServiceGroupHeIn()
                {
                    Id = Guid.NewGuid(),
                    Code = "10",
                    Name = "Vật tư y tế trong danh mục BHYT",
                    SortOrder = 10
                },
                new SServiceGroupHeIn()
                {
                    Id = Guid.NewGuid(),
                    Code = "11",
                    Name = "VTYT thanh toán theo tỷ lệ",
                    SortOrder = 11
                },
                new SServiceGroupHeIn()
                {
                    Id = Guid.NewGuid(),
                    Code = "12",
                    Name = "Vận chuyển",
                    SortOrder = 12
                },
                new SServiceGroupHeIn()
                {
                    Id = Guid.NewGuid(),
                    Code = "13",
                    Name = "Khám bệnh",
                    SortOrder = 13
                },
                new SServiceGroupHeIn()
                {
                    Id = Guid.NewGuid(),
                    Code = "14",
                    Name = "Giường điều trị ngoại trú",
                    SortOrder = 14
                },
                new SServiceGroupHeIn()
                {
                    Id = Guid.NewGuid(),
                    Code = "15",
                    Name = "Giường điều trị nội trú",
                    SortOrder = 15
                },
                new SServiceGroupHeIn()
                {
                    Id = Guid.NewGuid(),
                    Code = "16",
                    Name = "Ngày giường lưu",
                    SortOrder = 16
                },
                new SServiceGroupHeIn()
                {
                    Id = Guid.NewGuid(),
                    Code = "17",
                    Name = "Chế phẩm máu",
                    SortOrder = 17
                },
                new SServiceGroupHeIn()
                {
                    Id = Guid.NewGuid(),
                    Code = "18",
                    Name = "Thủ thuật",
                    SortOrder = 18
                });
        }
    }
}
