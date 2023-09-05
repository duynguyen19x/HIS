using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public static class ServiceGroupHeInBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceGroupHeIn>().HasData(
                new ServiceGroupHeIn()
                {
                    Id = new Guid("45E3F5DE-4096-4944-A6B6-69B829B0F61F"),
                    Code = "XN",
                    Name = "Xét nghiệm",
                    SortOrder = (int)ServiceGroupHeInTypes.LaboratoryTesting
                },
                new ServiceGroupHeIn()
                {
                    Id = new Guid("B2E25F8F-EA5B-4255-B2D8-379BD50A5160"),
                    Code = "CDHA",
                    Name = "Chẩn đoán hình ảnh",
                    SortOrder = (int)ServiceGroupHeInTypes.DiagnosticImaging
                },
                new ServiceGroupHeIn()
                {
                    Id = new Guid("7A871FF7-C167-4FC8-B652-0AA2ECD72444"),
                    Code = "TDCN",
                    Name = "Thăm dò chức năng",
                    SortOrder = (int)ServiceGroupHeInTypes.FunctionalEvaluation
                },
                new ServiceGroupHeIn()
                {
                    Id = new Guid("7D39F21A-3F78-4C5A-B288-02532A9769D7"),
                    Code = "THUOC-BHYT",
                    Name = "Thuốc trong danh mục BHYT",
                    SortOrder = (int)ServiceGroupHeInTypes.ItemHeInList
                },
                new ServiceGroupHeIn()
                {
                    Id = new Guid("90ADCFC5-7518-46E2-995F-D304C31583B5"),
                    Code = "THUOC-NgBHYT",
                    Name = "Thuốc điều trị ung thư, chống thải ghép ngoài danh mục",
                    SortOrder = (int)ServiceGroupHeInTypes.ItemOutHeInList
                },
                new ServiceGroupHeIn()
                {
                    Id = new Guid("53BF47C7-1414-47CF-8C88-5BA96AA2C978"),
                    Code = "THUOC-TT",
                    Name = "Thuốc thanh toán theo tỷ lệ",
                    SortOrder = (int)ServiceGroupHeInTypes.ItemPaymentRate
                },
                new ServiceGroupHeIn()
                {
                    Id = new Guid("8A6EEE59-ECB3-4BEA-89CD-1A83B2D8EDD6"),
                    Code = "MAU",
                    Name = "Máu",
                    SortOrder = (int)ServiceGroupHeInTypes.Blood
                },
                new ServiceGroupHeIn()
                {
                    Id = new Guid("8C7964AD-F476-4009-A630-A14DE7F982D6"),
                    Code = "PT",
                    Name = "Phẫu thuật",
                    SortOrder = (int)ServiceGroupHeInTypes.Surgery
                },
                new ServiceGroupHeIn()
                {
                    Id = new Guid("7C84BD56-F322-477C-B64D-50655CBC06E5"),
                    Code = "DVKT-TL",
                    Name = "DVKT thanh toán theo tỷ lệ",
                    SortOrder = 9
                },
                new ServiceGroupHeIn()
                {
                    Id = new Guid("8A360961-1C49-4382-A7CE-CE70358AE25A"),
                    Code = "VTYT-BHYT",
                    Name = "Vật tư y tế trong danh mục BHYT",
                    SortOrder = (int)ServiceGroupHeInTypes.MaterialHeInList
                },
                new ServiceGroupHeIn()
                {
                    Id = new Guid("8868DFD1-FBC7-40C2-83B1-CB0F894CF566"),
                    Code = "VTYT-TT",
                    Name = "VTYT thanh toán theo tỷ lệ",
                    SortOrder = (int)ServiceGroupHeInTypes.MaterialPaymentRate
                },
                new ServiceGroupHeIn()
                {
                    Id = new Guid("81A882DB-D465-402F-A391-D3726D698950"),
                    Code = "VC",
                    Name = "Vận chuyển",
                    SortOrder = (int)ServiceGroupHeInTypes.Transportation
                },
                new ServiceGroupHeIn()
                {
                    Id = new Guid("75B2F46F-F841-4CBE-9513-93C44306E78E"),
                    Code = "KHAM",
                    Name = "Khám bệnh",
                    SortOrder = (int)ServiceGroupHeInTypes.MedicalExamination
                },
                new ServiceGroupHeIn()
                {
                    Id = new Guid("675D16DB-CD35-4229-B042-82AEF4718AFF"),
                    Code = ((int)ServiceGroupHeInTypes.OutpatientBed).ToString(),
                    Name = "Giường điều trị ngoại trú",
                    SortOrder = (int)ServiceGroupHeInTypes.OutpatientBed
                },
                new ServiceGroupHeIn()
                {
                    Id = new Guid("156EC951-453D-4E3F-800E-33F850942874"),
                    Code = "GI-NT",
                    Name = "Giường điều trị nội trú",
                    SortOrder = (int)ServiceGroupHeInTypes.InpatientBed
                },
                new ServiceGroupHeIn()
                {
                    Id = new Guid("22048FA7-A9E4-4AC7-89A6-E9E34E4811B4"),
                    Code = "GI-LUU",
                    Name = "Ngày giường lưu",
                    SortOrder = (int)ServiceGroupHeInTypes.BedOccupancyDay
                },
                new ServiceGroupHeIn()
                {
                    Id = new Guid("7802D629-9E6A-48A7-825C-C91F530785AC"),
                    Code = "CPM",
                    Name = "Chế phẩm máu",
                    SortOrder = (int)ServiceGroupHeInTypes.BloodProduct
                },
                new ServiceGroupHeIn()
                {
                    Id = new Guid("199B0C88-0EF5-475C-A426-C0547CD13443"),
                    Code = "TT",
                    Name = "Thủ thuật",
                    SortOrder = (int)ServiceGroupHeInTypes.SurgicalIntervention
                },
                new ServiceGroupHeIn()
                {
                    Id = new Guid("DC75E4BB-6E85-4A90-AE29-112B7D2873F9"),
                    Code = "VTYT-NgBHYT",
                    Name = "Vật tư y tế ngoài danh mục BHYT",
                    SortOrder = (int)ServiceGroupHeInTypes.MaterialOutHeInList
                });
        }
    }
}
