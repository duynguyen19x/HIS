using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class TreatmentEndTypeConfiguration : IEntityTypeConfiguration<TreatmentEndType>
    {
        public void Configure(EntityTypeBuilder<TreatmentEndType> builder)
        {
            builder.ToTable("TreatmentEndTypes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.TreatmentEndTypeCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.TreatmentEndTypeName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);


            builder.HasData(
                new TreatmentEndType { Id = (int)TreatmentEndTypes.CAPTOACHOVE, TreatmentEndTypeCode = TreatmentEndTypes.CAPTOACHOVE.ToString(), TreatmentEndTypeName = "Cấp toa cho về", IsForOutPatient = true, IsForInPatient = false, SortOrder = 1 },
                new TreatmentEndType { Id = (int)TreatmentEndTypes.HEN, TreatmentEndTypeCode = TreatmentEndTypes.HEN.ToString(), TreatmentEndTypeName = "Hẹn", IsForOutPatient = true, IsForInPatient = false, SortOrder = 1 },
                new TreatmentEndType { Id = (int)TreatmentEndTypes.CHUYEN_PHONGKHAM, TreatmentEndTypeCode = TreatmentEndTypes.CHUYEN_PHONGKHAM.ToString(), TreatmentEndTypeName = "Chuyển phòng khám", IsForOutPatient = true, IsForInPatient = false, SortOrder = 2 },
                new TreatmentEndType { Id = (int)TreatmentEndTypes.DTRI_NGOAITRU, TreatmentEndTypeCode = TreatmentEndTypes.DTRI_NGOAITRU.ToString(), TreatmentEndTypeName = "Điều trị ngoại trú", IsForOutPatient = true, IsForInPatient = false, SortOrder = 3 },
                new TreatmentEndType { Id = (int)TreatmentEndTypes.NHAPVIEN, TreatmentEndTypeCode = TreatmentEndTypes.NHAPVIEN.ToString(), TreatmentEndTypeName = "Nhập viện", IsForOutPatient = true, IsForInPatient = false, SortOrder = 4 },
                new TreatmentEndType { Id = (int)TreatmentEndTypes.BOKHAM, TreatmentEndTypeCode = TreatmentEndTypes.BOKHAM.ToString(), TreatmentEndTypeName = "Bỏ khám", IsForOutPatient = true, IsForInPatient = false, SortOrder = 5 },
                new TreatmentEndType { Id = (int)TreatmentEndTypes.CHUYEN_KHOA, TreatmentEndTypeCode = TreatmentEndTypes.CHUYEN_KHOA.ToString(), TreatmentEndTypeName = "Chuyển khoa", IsForOutPatient = true, IsForInPatient = true, SortOrder = 8 },
                new TreatmentEndType { Id = (int)TreatmentEndTypes.RAVIEN, TreatmentEndTypeCode = TreatmentEndTypes.RAVIEN.ToString(), TreatmentEndTypeName = "Ra viện", IsForOutPatient = false, IsForInPatient = true, SortOrder = 1 },
                new TreatmentEndType { Id = (int)TreatmentEndTypes.XINVE, TreatmentEndTypeCode = TreatmentEndTypes.XINVE.ToString(), TreatmentEndTypeName = "Xin về", IsForOutPatient = false, IsForInPatient = true, SortOrder = 2 },
                new TreatmentEndType { Id = (int)TreatmentEndTypes.DUAVE, TreatmentEndTypeCode = TreatmentEndTypes.DUAVE.ToString(), TreatmentEndTypeName = "Đưa về", IsForOutPatient = false, IsForInPatient = true, SortOrder = 3 },
                new TreatmentEndType { Id = (int)TreatmentEndTypes.TRONVIEN, TreatmentEndTypeCode = TreatmentEndTypes.TRONVIEN.ToString(), TreatmentEndTypeName = "Trốn viện", IsForOutPatient = false, IsForInPatient = true, SortOrder = 4 },
                new TreatmentEndType { Id = (int)TreatmentEndTypes.CHUYEN_TUYEN, TreatmentEndTypeCode = TreatmentEndTypes.CHUYEN_TUYEN.ToString(), TreatmentEndTypeName = "Chuyển tuyến", IsForOutPatient = true, IsForInPatient = false, SortOrder = 6 },
                new TreatmentEndType { Id = (int)TreatmentEndTypes.TUVONG, TreatmentEndTypeCode = TreatmentEndTypes.TUVONG.ToString(), TreatmentEndTypeName = "Tử vong", IsForOutPatient = true, IsForInPatient = true, SortOrder = 7 },
                new TreatmentEndType { Id = (int)TreatmentEndTypes.KHAC, TreatmentEndTypeCode = TreatmentEndTypes.KHAC.ToString(), TreatmentEndTypeName = "Khác", IsForOutPatient = true, IsForInPatient = true, SortOrder = 99 }
            );
        }
    }
}
