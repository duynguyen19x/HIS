using HIS.EntityFrameworkCore.Entities;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class TreatmentEndTypeConfiguration : IEntityTypeConfiguration<TreatmentEndType>
    {
        public void Configure(EntityTypeBuilder<TreatmentEndType> builder)
        {
            builder.HasData(
                new TreatmentEndType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DITreatmentEndType.CAPTOACHOVE, Code = DITreatmentEndType.CAPTOACHOVE.ToString(), Name = "Cấp toa cho về", IsForOutPatient = true, IsForInPatient = false, SortOrder = 1 },
                new TreatmentEndType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DITreatmentEndType.HEN, Code = DITreatmentEndType.HEN.ToString(), Name = "Hẹn", IsForOutPatient = true, IsForInPatient = true, SortOrder = 2 },
                new TreatmentEndType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DITreatmentEndType.CHUYEN_PHONGKHAM, Code = DITreatmentEndType.CHUYEN_PHONGKHAM.ToString(), Name = "Chuyển phòng khám", IsForOutPatient = true, IsForInPatient = false, SortOrder = 3 },
                new TreatmentEndType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DITreatmentEndType.DTRI_NGOAITRU, Code = DITreatmentEndType.DTRI_NGOAITRU.ToString(), Name = "Điều trị ngoại trú", IsForOutPatient = true, IsForInPatient = true, SortOrder = 4 },
                new TreatmentEndType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DITreatmentEndType.NHAPVIEN, Code = DITreatmentEndType.NHAPVIEN.ToString(), Name = "Nhập viện", IsForOutPatient = true, IsForInPatient = false, SortOrder = 5 },
                new TreatmentEndType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DITreatmentEndType.BOKHAM, Code = DITreatmentEndType.BOKHAM.ToString(), Name = "Bỏ khám", IsForOutPatient = true, IsForInPatient = false, SortOrder = 6 },
                new TreatmentEndType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DITreatmentEndType.CHUYEN_KHOA, Code = DITreatmentEndType.CHUYEN_KHOA.ToString(), Name = "Chuyển khoa", IsForOutPatient = true, IsForInPatient = true, SortOrder = 7 },
                new TreatmentEndType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DITreatmentEndType.RAVIEN, Code = DITreatmentEndType.RAVIEN.ToString(), Name = "Ra viện", IsForOutPatient = false, IsForInPatient = true, SortOrder = 8 },
                new TreatmentEndType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DITreatmentEndType.XINVE, Code = DITreatmentEndType.XINVE.ToString(), Name = "Xin về", IsForOutPatient = true, IsForInPatient = true, SortOrder = 9 },
                new TreatmentEndType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DITreatmentEndType.DUAVE, Code = DITreatmentEndType.DUAVE.ToString(), Name = "Đưa về", IsForOutPatient = true, IsForInPatient = true, SortOrder = 10 },
                new TreatmentEndType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DITreatmentEndType.TRONVIEN, Code = DITreatmentEndType.TRONVIEN.ToString(), Name = "Trốn viện", IsForOutPatient = false, IsForInPatient = true, SortOrder = 11 },
                new TreatmentEndType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DITreatmentEndType.CHUYEN_TUYEN, Code = DITreatmentEndType.CHUYEN_TUYEN.ToString(), Name = "Chuyển tuyến", IsForOutPatient = true, IsForInPatient = true, SortOrder = 12 },
                new TreatmentEndType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DITreatmentEndType.TUVONG, Code = DITreatmentEndType.TUVONG.ToString(), Name = "Tử vong", IsForOutPatient = true, IsForInPatient = true, SortOrder = 13 },
                new TreatmentEndType() { CreatedDate = new DateTime(2024, 1, 1), Id = (int)DITreatmentEndType.KHAC, Code = DITreatmentEndType.KHAC.ToString(), Name = "Khác", IsForOutPatient = false, IsForInPatient = false, SortOrder = 99 }
                );
        }
    }
}
