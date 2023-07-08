using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data
{
    public class RoomTypeBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SRoomType>().HasData(
                new SRoomType()
                {
                    Id = (int)RoomTypes.Reception,
                    Code = "TD",
                    Name = "Tiếp đón",
                    SortOrder = (int)RoomTypes.Reception
                },
                new SRoomType()
                {
                    Id = (int)RoomTypes.Administration,
                    Code = "HC",
                    Name = "Hành chính",
                    SortOrder = (int)RoomTypes.Administration
                },
                new SRoomType()
                {
                    Id = (int)RoomTypes.MedicalExamination,
                    Code = "KHAM",
                    Name = "Khám bệnh",
                    SortOrder = (int)RoomTypes.MedicalExamination
                },
                new SRoomType()
                {
                    Id = (int)RoomTypes.InpatientTreatment,
                    Code = "NT",
                    Name = "Nội trú",
                    SortOrder = (int)RoomTypes.InpatientTreatment
                },
                new SRoomType()
                {
                    Id = (int)RoomTypes.Outpatient,
                    Code = "NgT",
                    Name = "Ngoại trú",
                    SortOrder = (int)RoomTypes.Outpatient
                },
                new SRoomType()
                {
                    Id = (int)RoomTypes.LaboratoryTesting,
                    Code = "XN",
                    Name = "Xét nghiệm",
                    SortOrder = (int)RoomTypes.LaboratoryTesting
                },
                new SRoomType()
                {
                    Id = (int)RoomTypes.DiagnosticImaging,
                    Code = "CDHA",
                    Name = "Chẩn đoán hình ảnh",
                    SortOrder = (int)RoomTypes.DiagnosticImaging
                },
                new SRoomType()
                {
                    Id = (int)RoomTypes.CentralWarehouse,
                    Code = "KHO-TONG",
                    Name = "Kho tổng",
                    SortOrder = (int)RoomTypes.CentralWarehouse
                },
                new SRoomType()
                {
                    Id = (int)RoomTypes.OutpatientPharmacy,
                    Code = "KHO-NgT",
                    Name = "Kho ngoại trú",
                    SortOrder = (int)RoomTypes.OutpatientPharmacy
                },
                new SRoomType()
                {
                    Id = (int)RoomTypes.InpatientPharmacy,
                    Code = "KHO-NT",
                    Name = "Kho nội trú",
                    SortOrder = (int)RoomTypes.InpatientPharmacy
                },
                new SRoomType()
                {
                    Id = (int)RoomTypes.EmergencyCabinet,
                    Code = "TT",
                    Name = "Tủ trực",
                    SortOrder = (int)RoomTypes.EmergencyCabinet
                },
                new SRoomType()
                {
                    Id = (int)RoomTypes.MedicineManagement,
                    Code = "QLT",
                    Name = "Quản lý thuốc",
                    SortOrder = (int)RoomTypes.MedicineManagement
                },
                new SRoomType()
                {
                    Id = (int)RoomTypes.MaterialManagement,
                    Code = "QLVT",
                    Name = "Quản lý vật tư",
                    SortOrder = (int)RoomTypes.MaterialManagement
                });
        }
    }
}
