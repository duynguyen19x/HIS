﻿using HIS.EntityFrameworkCore.Entities;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.HasData(
                new RoomType { CreatedDate = new DateTime(2024, 1, 1), Id = (int)RoomTypes.Reception, Code = "TD", Name = "Tiếp đón", SortOrder = (int)RoomTypes.Reception },
                new RoomType { CreatedDate = new DateTime(2024, 1, 1), Id = (int)RoomTypes.Administration, Code = "HC", Name = "Hành chính", SortOrder = (int)RoomTypes.Administration },
                new RoomType { CreatedDate = new DateTime(2024, 1, 1), Id = (int)RoomTypes.MedicalExamination, Code = "KHAM", Name = "Khám bệnh", SortOrder = (int)RoomTypes.MedicalExamination },
                new RoomType { CreatedDate = new DateTime(2024, 1, 1), Id = (int)RoomTypes.InpatientTreatment, Code = "NT", Name = "Nội trú", SortOrder = (int)RoomTypes.InpatientTreatment },
                new RoomType { CreatedDate = new DateTime(2024, 1, 1), Id = (int)RoomTypes.Outpatient, Code = "NgT", Name = "Ngoại trú", SortOrder = (int)RoomTypes.Outpatient },
                new RoomType { CreatedDate = new DateTime(2024, 1, 1), Id = (int)RoomTypes.LaboratoryTesting, Code = "XN", Name = "Xét nghiệm", SortOrder = (int)RoomTypes.LaboratoryTesting },
                new RoomType { CreatedDate = new DateTime(2024, 1, 1), Id = (int)RoomTypes.DiagnosticImaging, Code = "CDHA", Name = "Chẩn đoán hình ảnh", SortOrder = (int)RoomTypes.DiagnosticImaging },
                new RoomType { CreatedDate = new DateTime(2024, 1, 1), Id = (int)RoomTypes.CentralWarehouse, Code = "KHO-TONG", Name = "Kho tổng", SortOrder = (int)RoomTypes.CentralWarehouse },
                new RoomType { CreatedDate = new DateTime(2024, 1, 1), Id = (int)RoomTypes.OutpatientPharmacy, Code = "KHO-NgT", Name = "Kho thuốc ngoại trú", SortOrder = (int)RoomTypes.OutpatientPharmacy },
                new RoomType { CreatedDate = new DateTime(2024, 1, 1), Id = (int)RoomTypes.InpatientPharmacy, Code = "KHO-NT", Name = "Kho thuốc nội trú", SortOrder = (int)RoomTypes.InpatientPharmacy },
                new RoomType { CreatedDate = new DateTime(2024, 1, 1), Id = (int)RoomTypes.EmergencyCabinet, Code = "TT-TH", Name = "Tủ trực thuốc", SortOrder = (int)RoomTypes.EmergencyCabinet },
                new RoomType { CreatedDate = new DateTime(2024, 1, 1), Id = (int)RoomTypes.OutpatientInventory, Code = "KHO-VTYT", Name = "Kho vật tự y tế", SortOrder = (int)RoomTypes.OutpatientInventory },
                new RoomType { CreatedDate = new DateTime(2024, 1, 1), Id = (int)RoomTypes.BloodBack, Code = "KHO-MAU", Name = "Kho máu", SortOrder = (int)RoomTypes.BloodBack },
                new RoomType { CreatedDate = new DateTime(2024, 1, 1), Id = (int)RoomTypes.InventoryCabinet, Code = "TT-VT", Name = "Tủ trực VTYT", SortOrder = (int)RoomTypes.InventoryCabinet },
                new RoomType { CreatedDate = new DateTime(2024, 1, 1), Id = (int)RoomTypes.ItemManagement, Code = "QLT", Name = "Quản lý thuốc", SortOrder = (int)RoomTypes.ItemManagement },
                new RoomType { CreatedDate = new DateTime(2024, 1, 1), Id = (int)RoomTypes.MaterialManagement, Code = "QLVT", Name = "Quản lý vật tư", SortOrder = (int)RoomTypes.MaterialManagement });
        }
    }
}
