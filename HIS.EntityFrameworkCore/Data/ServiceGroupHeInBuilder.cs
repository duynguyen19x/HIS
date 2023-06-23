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
                    Id = new Guid("45E3F5DE-4096-4944-A6B6-69B829B0F61F"),
                    Code = "1",
                    Name = "Xét nghiệm",
                    SortOrder = 1
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("B2E25F8F-EA5B-4255-B2D8-379BD50A5160"),
                    Code = "2",
                    Name = "Chẩn đoán hình ảnh",
                    SortOrder = 2
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("7A871FF7-C167-4FC8-B652-0AA2ECD72444"),
                    Code = "3",
                    Name = "Thăm dò chức năng",
                    SortOrder = 3
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("7D39F21A-3F78-4C5A-B288-02532A9769D7"),
                    Code = "4",
                    Name = "Thuốc trong danh mục BHYT",
                    SortOrder = 4
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("90ADCFC5-7518-46E2-995F-D304C31583B5"),
                    Code = "5",
                    Name = "Thuốc điều trị ung thư, chống thải ghép ngoài danh mục",
                    SortOrder = 5
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("53BF47C7-1414-47CF-8C88-5BA96AA2C978"),
                    Code = "6",
                    Name = "Thuốc thanh toán theo tỷ lệ",
                    SortOrder = 6
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("8A6EEE59-ECB3-4BEA-89CD-1A83B2D8EDD6"),
                    Code = "7",
                    Name = "Máu và chế phẩm máu",
                    SortOrder = 7
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("8C7964AD-F476-4009-A630-A14DE7F982D6"),
                    Code = "8",
                    Name = "Phẫu thuật",
                    SortOrder = 8
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("7C84BD56-F322-477C-B64D-50655CBC06E5"),
                    Code = "9",
                    Name = "DVKT thanh toán theo tỷ lệ",
                    SortOrder = 9
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("8A360961-1C49-4382-A7CE-CE70358AE25A"),
                    Code = "10",
                    Name = "Vật tư y tế trong danh mục BHYT",
                    SortOrder = 10
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("8868DFD1-FBC7-40C2-83B1-CB0F894CF566"),
                    Code = "11",
                    Name = "VTYT thanh toán theo tỷ lệ",
                    SortOrder = 11
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("81A882DB-D465-402F-A391-D3726D698950"),
                    Code = "12",
                    Name = "Vận chuyển",
                    SortOrder = 12
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("75B2F46F-F841-4CBE-9513-93C44306E78E"),
                    Code = "13",
                    Name = "Khám bệnh",
                    SortOrder = 13
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("675D16DB-CD35-4229-B042-82AEF4718AFF"),
                    Code = "14",
                    Name = "Giường điều trị ngoại trú",
                    SortOrder = 14
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("156EC951-453D-4E3F-800E-33F850942874"),
                    Code = "15",
                    Name = "Giường điều trị nội trú",
                    SortOrder = 15
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("22048FA7-A9E4-4AC7-89A6-E9E34E4811B4"),
                    Code = "16",
                    Name = "Ngày giường lưu",
                    SortOrder = 16
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("7802D629-9E6A-48A7-825C-C91F530785AC"),
                    Code = "17",
                    Name = "Chế phẩm máu",
                    SortOrder = 17
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("199B0C88-0EF5-475C-A426-C0547CD13443"),
                    Code = "18",
                    Name = "Thủ thuật",
                    SortOrder = 18
                });
        }
    }
}
