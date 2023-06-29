using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.Utilities.Enums;
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
                    Code = ((int)ServiceGroupHeInTypes.LaboratoryTesting).ToString(),
                    Name = "Xét nghiệm",
                    SortOrder = (int)ServiceGroupHeInTypes.LaboratoryTesting
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("B2E25F8F-EA5B-4255-B2D8-379BD50A5160"),
                    Code = ((int)ServiceGroupHeInTypes.DiagnosticImaging).ToString(),
                    Name = "Chẩn đoán hình ảnh",
                    SortOrder = (int)ServiceGroupHeInTypes.DiagnosticImaging
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("7A871FF7-C167-4FC8-B652-0AA2ECD72444"),
                    Code = ((int)ServiceGroupHeInTypes.FunctionalEvaluation).ToString(),
                    Name = "Thăm dò chức năng",
                    SortOrder = (int)ServiceGroupHeInTypes.FunctionalEvaluation
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("7D39F21A-3F78-4C5A-B288-02532A9769D7"),
                    Code = ((int)ServiceGroupHeInTypes.MedicineHeInList).ToString(),
                    Name = "Thuốc trong danh mục BHYT",
                    SortOrder = (int)ServiceGroupHeInTypes.MedicineHeInList
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("90ADCFC5-7518-46E2-995F-D304C31583B5"),
                    Code = ((int)ServiceGroupHeInTypes.MedicineOutHeInList).ToString(),
                    Name = "Thuốc điều trị ung thư, chống thải ghép ngoài danh mục",
                    SortOrder = (int)ServiceGroupHeInTypes.MedicineOutHeInList
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("53BF47C7-1414-47CF-8C88-5BA96AA2C978"),
                    Code = ((int)ServiceGroupHeInTypes.MedicinePaymentRate).ToString(),
                    Name = "Thuốc thanh toán theo tỷ lệ",
                    SortOrder = (int)ServiceGroupHeInTypes.MedicinePaymentRate
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("8A6EEE59-ECB3-4BEA-89CD-1A83B2D8EDD6"),
                    Code = ((int)ServiceGroupHeInTypes.Blood).ToString(),
                    Name = "Máu và chế phẩm máu",
                    SortOrder = (int)ServiceGroupHeInTypes.Blood
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("8C7964AD-F476-4009-A630-A14DE7F982D6"),
                    Code = ((int)ServiceGroupHeInTypes.Surgery).ToString(),
                    Name = "Phẫu thuật",
                    SortOrder = (int)ServiceGroupHeInTypes.Surgery
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("7C84BD56-F322-477C-B64D-50655CBC06E5"),
                    Code = ((int)ServiceGroupHeInTypes.ServicePaymentRate).ToString(),
                    Name = "DVKT thanh toán theo tỷ lệ",
                    SortOrder = 9
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("8A360961-1C49-4382-A7CE-CE70358AE25A"),
                    Code = ((int)ServiceGroupHeInTypes.MaterialHeInList).ToString(),
                    Name = "Vật tư y tế trong danh mục BHYT",
                    SortOrder = (int)ServiceGroupHeInTypes.MaterialHeInList
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("8868DFD1-FBC7-40C2-83B1-CB0F894CF566"),
                    Code = ((int)ServiceGroupHeInTypes.MaterialPaymentRate).ToString(),
                    Name = "VTYT thanh toán theo tỷ lệ",
                    SortOrder = (int)ServiceGroupHeInTypes.MaterialPaymentRate
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("81A882DB-D465-402F-A391-D3726D698950"),
                    Code = ((int)ServiceGroupHeInTypes.Transportation).ToString(),
                    Name = "Vận chuyển",
                    SortOrder = (int)ServiceGroupHeInTypes.Transportation
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("75B2F46F-F841-4CBE-9513-93C44306E78E"),
                    Code = ((int)ServiceGroupHeInTypes.MedicalExamination).ToString(),
                    Name = "Khám bệnh",
                    SortOrder = (int)ServiceGroupHeInTypes.MedicalExamination
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("675D16DB-CD35-4229-B042-82AEF4718AFF"),
                    Code = ((int)ServiceGroupHeInTypes.OutpatientBed).ToString(),
                    Name = "Giường điều trị ngoại trú",
                    SortOrder = (int)ServiceGroupHeInTypes.OutpatientBed
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("156EC951-453D-4E3F-800E-33F850942874"),
                    Code = ((int)ServiceGroupHeInTypes.InpatientBed).ToString(),
                    Name = "Giường điều trị nội trú",
                    SortOrder = (int)ServiceGroupHeInTypes.InpatientBed
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("22048FA7-A9E4-4AC7-89A6-E9E34E4811B4"),
                    Code = ((int)ServiceGroupHeInTypes.BedOccupancyDay).ToString(),
                    Name = "Ngày giường lưu",
                    SortOrder = (int)ServiceGroupHeInTypes.BedOccupancyDay
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("7802D629-9E6A-48A7-825C-C91F530785AC"),
                    Code = ((int)ServiceGroupHeInTypes.BloodProduct).ToString(),
                    Name = "Chế phẩm máu",
                    SortOrder = (int)ServiceGroupHeInTypes.BloodProduct
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("199B0C88-0EF5-475C-A426-C0547CD13443"),
                    Code = ((int)ServiceGroupHeInTypes.SurgicalIntervention).ToString(),
                    Name = "Thủ thuật",
                    SortOrder = (int)ServiceGroupHeInTypes.SurgicalIntervention
                },
                new SServiceGroupHeIn()
                {
                    Id = new Guid("DC75E4BB-6E85-4A90-AE29-112B7D2873F9"),
                    Code = ((int)ServiceGroupHeInTypes.MaterialOutHeInList).ToString(),
                    Name = "Vật tư y tế ngoài danh mục BHYT",
                    SortOrder = (int)ServiceGroupHeInTypes.MaterialOutHeInList
                });
        }
    }
}
