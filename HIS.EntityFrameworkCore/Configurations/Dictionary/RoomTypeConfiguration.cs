using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class RoomTypeConfiguration : IEntityTypeConfiguration<DIRoomType>
    {
        public void Configure(EntityTypeBuilder<DIRoomType> builder)
        {
            builder.ToTable("DIC_RoomType");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(20).IsRequired(); 
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired(); 
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasData(
                new DIRoomType { Id = (int)RoomTypes.Reception, Code = "TD", Name = "Tiếp đón", SortOrder = (int)RoomTypes.Reception },
                new DIRoomType { Id = (int)RoomTypes.Administration, Code = "HC", Name = "Hành chính", SortOrder = (int)RoomTypes.Administration },
                new DIRoomType { Id = (int)RoomTypes.MedicalExamination, Code = "KHAM", Name = "Khám bệnh", SortOrder = (int)RoomTypes.MedicalExamination },
                new DIRoomType { Id = (int)RoomTypes.InpatientTreatment, Code = "NT", Name = "Nội trú", SortOrder = (int)RoomTypes.InpatientTreatment },
                new DIRoomType { Id = (int)RoomTypes.Outpatient, Code = "NgT", Name = "Ngoại trú", SortOrder = (int)RoomTypes.Outpatient },
                new DIRoomType { Id = (int)RoomTypes.LaboratoryTesting, Code = "XN", Name = "Xét nghiệm", SortOrder = (int)RoomTypes.LaboratoryTesting },
                new DIRoomType { Id = (int)RoomTypes.DiagnosticImaging, Code = "CDHA", Name = "Chẩn đoán hình ảnh", SortOrder = (int)RoomTypes.DiagnosticImaging },
                new DIRoomType { Id = (int)RoomTypes.CentralWarehouse, Code = "KHO-TONG", Name = "Kho tổng", SortOrder = (int)RoomTypes.CentralWarehouse },
                new DIRoomType { Id = (int)RoomTypes.OutpatientPharmacy, Code = "KHO-NgT", Name = "Kho thuốc ngoại trú", SortOrder = (int)RoomTypes.OutpatientPharmacy },
                new DIRoomType { Id = (int)RoomTypes.InpatientPharmacy, Code = "KHO-NT", Name = "Kho thuốc nội trú", SortOrder = (int)RoomTypes.InpatientPharmacy },
                new DIRoomType { Id = (int)RoomTypes.EmergencyCabinet, Code = "TT-TH", Name = "Tủ trực thuốc", SortOrder = (int)RoomTypes.EmergencyCabinet },
                new DIRoomType { Id = (int)RoomTypes.OutpatientInventory, Code = "KHO-VTYT", Name = "Kho vật tự y tế", SortOrder = (int)RoomTypes.OutpatientInventory },
                new DIRoomType { Id = (int)RoomTypes.BloodBack, Code = "KHO-MAU", Name = "Kho máu", SortOrder = (int)RoomTypes.BloodBack },
                new DIRoomType { Id = (int)RoomTypes.InventoryCabinet, Code = "TT-VT", Name = "Tủ trực VTYT", SortOrder = (int)RoomTypes.InventoryCabinet },
                new DIRoomType { Id = (int)RoomTypes.ItemManagement, Code = "QLT", Name = "Quản lý thuốc", SortOrder = (int)RoomTypes.ItemManagement },
                new DIRoomType { Id = (int)RoomTypes.MaterialManagement, Code = "QLVT", Name = "Quản lý vật tư", SortOrder = (int)RoomTypes.MaterialManagement });
        }
    }
}
