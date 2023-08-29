using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public class MedicalRecordEndTypeBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicalRecordEndType>().HasData(
                new MedicalRecordEndType((int)MedicalRecordEndTypes.CAPTOACHOVE, MedicalRecordEndTypes.CAPTOACHOVE.ToString(), "Cấp toa cho về", true, false, 1),
                new MedicalRecordEndType((int)MedicalRecordEndTypes.HEN, MedicalRecordEndTypes.HEN.ToString(), "Hẹn", true, false, 1),
                new MedicalRecordEndType((int)MedicalRecordEndTypes.CHUYEN_PHONGKHAM, MedicalRecordEndTypes.CHUYEN_PHONGKHAM.ToString(), "Chuyển phòng khám", true, false, 2),
                new MedicalRecordEndType((int)MedicalRecordEndTypes.DTRI_NGOAITRU, MedicalRecordEndTypes.DTRI_NGOAITRU.ToString(), "Điều trị ngoại trú", true, false, 3),
                new MedicalRecordEndType((int)MedicalRecordEndTypes.NHAPVIEN, MedicalRecordEndTypes.NHAPVIEN.ToString(), "Nhập viện", true, false, 4),
                new MedicalRecordEndType((int)MedicalRecordEndTypes.BOKHAM, MedicalRecordEndTypes.BOKHAM.ToString(), "Bỏ khám", true, false, 5),
                new MedicalRecordEndType((int)MedicalRecordEndTypes.CHUYEN_KHOA, MedicalRecordEndTypes.CHUYEN_KHOA.ToString(), "Chuyển khoa", true, true, 8),
                new MedicalRecordEndType((int)MedicalRecordEndTypes.RAVIEN, MedicalRecordEndTypes.RAVIEN.ToString(), "Ra viện", false, true, 1),
                new MedicalRecordEndType((int)MedicalRecordEndTypes.XINVE, MedicalRecordEndTypes.XINVE.ToString(), "Xin về", false, true, 2),
                new MedicalRecordEndType((int)MedicalRecordEndTypes.DUAVE, MedicalRecordEndTypes.DUAVE.ToString(), "Đưa về", false, true, 3),
                new MedicalRecordEndType((int)MedicalRecordEndTypes.TRONVIEN, MedicalRecordEndTypes.TRONVIEN.ToString(), "Trốn viện", false, true, 4),
                new MedicalRecordEndType((int)MedicalRecordEndTypes.CHUYEN_TUYEN, MedicalRecordEndTypes.CHUYEN_TUYEN.ToString(), "Chuyển tuyến", true, false, 6),
                new MedicalRecordEndType((int)MedicalRecordEndTypes.TUVONG, MedicalRecordEndTypes.TUVONG.ToString(), "Tử vong", true, true, 7),
                new MedicalRecordEndType((int)MedicalRecordEndTypes.KHAC, MedicalRecordEndTypes.KHAC.ToString(), "Khác", true, true, 99)
            );
        }
    }
}
