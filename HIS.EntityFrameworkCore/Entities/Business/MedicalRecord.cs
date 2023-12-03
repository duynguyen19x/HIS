using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Bệnh án (theo khoa): lưu các thông tin chung của đợt vào khoa
    /// </summary>
    public class MedicalRecord : FullAuditedEntity<Guid>
    {
        public string MedicalRecordCode { get; set; }
        public DateTime MedicalRecordDate { get; set; } // thời gian gửi yêu cầu tiếp nhận từ tiếp đón hoặc khoa khác
        public int MedicalRecordTypeID { get; set; } // loại bệnh án
        public int MedicalRecordStatusID { get; set; } // trạng thái: 0 - chờ, 100 - đang điều trị, 200 - đã kết thúc điều trị
        public int TreatmentResultTypeID { get; set; } // kết quả điều trị
        public int TreatmentEndTypeID { get; set; } // hình thức xử trí
        public Guid? PreviusMedicalRecordID { get; set; } // khoa trước đó (nếu có)
        public Guid? NextMedicalRecordID { get; set; } // khoa tiếp theo (nếu có)

        public Guid PatientRecordID { get; set; } // mã hồ sơ bệnh án
        public Guid DepartmentID { get; set; } // khoa (bắt buộc)
        public Guid? RoomID { get; set; } // phòng (bắt buộc khi tiếp nhận bệnh nhân nhập viện)
        public Guid? BedID { get; set; } // giường
        public Guid? UserID { get; set; } // nguoi tiep nhan nhap khoa
        public Guid? DoctorUserID { get; set; } // bác sỹ (bắt buộc khi tiếp nhận bệnh nhân nhập viện) 

        public DateTime? InTime { get; set; } // thời gian tiếp nhận
        public string InIcdCode { get; set; }  // chẩn đoán vào khoa
        public string InIcdName { get; set; } // tên chẩn đoán vào khoa
        public string InIcdSubCode { get; set; } // chẩn đoán vào khoa kèm theo
        public string InIcdText { get; set; } // danh sách chẩn đoán vào khoa kèm theo
        public string InTraditionalIcdCode { get; set; } // chẩn đoán vào khoa yhct
        public string InTraditionalIcdName { get; set; } // tên chẩn đoán vào khoa yhct
        public string InTraditionalIcdSubCode { get; set; } // chẩn đoán vào khoa kèm theo yhct
        public string InTraditionalIcdText { get; set; } // danh sách chẩn đoán vào khoa kèm theo yhct (A01.0-Thương hàn;A01.1-Bệnh phó thương hàn A)

        public DateTime? OutTime { get; set; } // thời gian kết thúc điều trị tại khoa
        public string IcdCode { get; set; } // bệnh chính
        public string IcdName { get; set; } // tên bệnh chính
        public string IcdSubCode { get; set; } // bệnh kèm theo 
        public string IcdText { get; set; } // danh sách tên bệnh kèm theo
        public string TraditionalIcdCode { get; set; } // bệnh chính yhct
        public string TraditionalIcdName { get; set; } // tên bệnh chính yhct
        public string TraditionalIcdSubCode { get; set; } // bệnh kèm theo yhct
        public string TraditionalIcdText { get; set; } // tên bệnh kèm theo yhct
        public bool IsSurgery { get; set; } // phẫu thuật
        public bool IsProcedure { get; set; } // thủ thuật
        public bool IsStroke { get; set; } // tai biến
        public bool IsComplication { get; set; } // biến chứng

        public MedicalRecord() { }
    }
}
