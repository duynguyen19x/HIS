using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public class RoomTypeBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomType>().HasData(
                new RoomType  { Id = (int)RoomTypes.Reception, RoomTypeCode = "TD", RoomTypeName = "Tiếp đón", SortOrder = (int)RoomTypes.Reception },
                new RoomType { Id = (int)RoomTypes.Administration, RoomTypeCode = "HC", RoomTypeName = "Hành chính", SortOrder = (int)RoomTypes.Administration  },
                new RoomType { Id = (int)RoomTypes.MedicalExamination, RoomTypeCode = "KHAM", RoomTypeName = "Khám bệnh", SortOrder = (int)RoomTypes.MedicalExamination },
                new RoomType() { Id = (int)RoomTypes.InpatientTreatment, RoomTypeCode = "NT", RoomTypeName = "Nội trú", SortOrder = (int)RoomTypes.InpatientTreatment },
                new RoomType()
                {
                    Id = (int)RoomTypes.Outpatient,
                    RoomTypeCode = "NgT",
                    RoomTypeName = "Ngoại trú",
                    SortOrder = (int)RoomTypes.Outpatient
                },
                new RoomType()
                {
                    Id = (int)RoomTypes.LaboratoryTesting,
                    RoomTypeCode = "XN",
                    RoomTypeName = "Xét nghiệm",
                    SortOrder = (int)RoomTypes.LaboratoryTesting
                },
                new RoomType()
                {
                    Id = (int)RoomTypes.DiagnosticImaging,
                    RoomTypeCode = "CDHA",
                    RoomTypeName = "Chẩn đoán hình ảnh",
                    SortOrder = (int)RoomTypes.DiagnosticImaging
                },
                new RoomType()
                {
                    Id = (int)RoomTypes.CentralWarehouse,
                    RoomTypeCode = "KHO-TONG",
                    RoomTypeName = "Kho tổng",
                    SortOrder = (int)RoomTypes.CentralWarehouse
                },
                new RoomType()
                {
                    Id = (int)RoomTypes.OutpatientPharmacy,
                    RoomTypeCode = "KHO-NgT",
                    RoomTypeName = "Kho thuốc ngoại trú",
                    SortOrder = (int)RoomTypes.OutpatientPharmacy
                },
                new RoomType()
                {
                    Id = (int)RoomTypes.InpatientPharmacy,
                    RoomTypeCode = "KHO-NT",
                    RoomTypeName = "Kho thuốc nội trú",
                    SortOrder = (int)RoomTypes.InpatientPharmacy
                },
                new RoomType()
                {
                    Id = (int)RoomTypes.EmergencyCabinet,
                    RoomTypeCode = "TT-TH",
                    RoomTypeName = "Tủ trực thuốc",
                    SortOrder = (int)RoomTypes.EmergencyCabinet
                },
                new RoomType()
                {
                    Id = (int)RoomTypes.OutpatientInventory,
                    RoomTypeCode = "KHO-VTYT",
                    RoomTypeName = "Kho vật tự y tế",
                    SortOrder = (int)RoomTypes.OutpatientInventory
                },
                new RoomType()
                {
                    Id = (int)RoomTypes.BloodBack,
                    RoomTypeCode = "KHO-MAU",
                    RoomTypeName = "Kho máu",
                    SortOrder = (int)RoomTypes.BloodBack
                },
                new RoomType()
                {
                    Id = (int)RoomTypes.InventoryCabinet,
                    RoomTypeCode = "TT-VT",
                    RoomTypeName = "Tủ trực VTYT",
                    SortOrder = (int)RoomTypes.InventoryCabinet
                },
                new RoomType()
                {
                    Id = (int)RoomTypes.ItemManagement,
                    RoomTypeCode = "QLT",
                    RoomTypeName = "Quản lý thuốc",
                    SortOrder = (int)RoomTypes.ItemManagement
                },
                new RoomType()
                {
                    Id = (int)RoomTypes.MaterialManagement,
                    RoomTypeCode = "QLVT",
                    RoomTypeName = "Quản lý vật tư",
                    SortOrder = (int)RoomTypes.MaterialManagement
                });
        }
    }
}
