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
                    Id = new Guid("060982D3-E1DB-49C2-A8D0-10260F8134D6"),
                    Code = ((int)RoomTypes.Reception).ToString(),
                    Name = "Tiếp đón",
                    SortOrder = (int)RoomTypes.Reception
                },
                new SRoomType()
                {
                    Id = new Guid("8C024A8D-801E-4C47-8EA3-1787C4427FAA"),
                    Code = ((int)RoomTypes.Administration).ToString(),
                    Name = "Hành chính",
                    SortOrder = (int)RoomTypes.Administration
                },
                new SRoomType()
                {
                    Id = new Guid("41D3FAC7-C06D-4CC3-AE5D-B53DDA3F0B98"),
                    Code = ((int)RoomTypes.MedicalExamination).ToString(),
                    Name = "Khám bệnh",
                    SortOrder = (int)RoomTypes.MedicalExamination
                },
                new SRoomType()
                {
                    Id = new Guid("741CCA23-AEB0-49A3-A8FA-D81415CD6824"),
                    Code = ((int)RoomTypes.InpatientTreatment).ToString(),
                    Name = "Nội trú",
                    SortOrder = (int)RoomTypes.InpatientTreatment
                },
                new SRoomType()
                {
                    Id = new Guid("56C7C054-6713-4421-9ACB-E57C911E0051"),
                    Code = ((int)RoomTypes.Outpatient).ToString(),
                    Name = "Ngoại trú",
                    SortOrder = (int)RoomTypes.Outpatient
                },
                new SRoomType()
                {
                    Id = new Guid("305EEE25-13C6-408A-9235-AF56FA091D28"),
                    Code = ((int)RoomTypes.LaboratoryTesting).ToString(),
                    Name = "Xét nghiệm",
                    SortOrder = (int)RoomTypes.LaboratoryTesting
                },
                new SRoomType()
                {
                    Id = new Guid("9D87CAF2-7DBB-4F40-B989-A2FBD982EAFE"),
                    Code = ((int)RoomTypes.DiagnosticImaging).ToString(),
                    Name = "Chẩn đoán hình ảnh",
                    SortOrder = (int)RoomTypes.DiagnosticImaging
                },
                new SRoomType()
                {
                    Id = new Guid("C64EBD18-4652-4FD9-BC54-9940DE7D7BD9"),
                    Code = ((int)RoomTypes.CentralWarehouse).ToString(),
                    Name = "Kho tổng",
                    SortOrder = (int)RoomTypes.CentralWarehouse
                },
                new SRoomType()
                {
                    Id = new Guid("FE5FC851-B118-46F7-8E06-E907FE7E6454"),
                    Code = ((int)RoomTypes.OutpatientPharmacy).ToString(),
                    Name = "Kho ngoại trú",
                    SortOrder = (int)RoomTypes.OutpatientPharmacy
                },
                new SRoomType()
                {
                    Id = new Guid("EAE8827B-9FB8-4F90-B920-272523ED772B"),
                    Code = ((int)RoomTypes.InpatientPharmacy).ToString(),
                    Name = "Kho nội trú",
                    SortOrder = (int)RoomTypes.InpatientPharmacy
                },
                new SRoomType()
                {
                    Id = new Guid("5D27FEB2-7419-4853-BFEC-F93A1B59D47E"),
                    Code = ((int)RoomTypes.EmergencyCabinet).ToString(),
                    Name = "Tủ trực",
                    SortOrder = (int)RoomTypes.EmergencyCabinet
                },
                new SRoomType()
                {
                    Id = new Guid("B1D4AF6D-98AB-4A64-B362-60E857923E89"),
                    Code = ((int)RoomTypes.MedicationManagement).ToString(),
                    Name = "Quản lý thuốc",
                    SortOrder = (int)RoomTypes.MedicationManagement
                },
                new SRoomType()
                {
                    Id = new Guid("90A7D9D8-3C16-457D-81BE-47FD30940BE6"),
                    Code = ((int)RoomTypes.MedicalManagement).ToString(),
                    Name = "Quản lý vật tư",
                    SortOrder = (int)RoomTypes.MedicalManagement
                });
        }
    }
}
