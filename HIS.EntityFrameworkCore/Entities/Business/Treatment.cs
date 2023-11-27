using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Phiếu điều trị.
    /// </summary>
    public class Treatment : FullAuditedEntity<Guid>
    {
        public Guid MedicalRecordID { get; set; } // bệnh án
        public int MedicalRecordTypeID { get; set; } // loại bệnh án
        public Guid DepartmentID { get; set; } // khoa điều trị
        public Guid RoomID { get; set; } // phòng, buồng điều trị
        public Guid BedID { get; set; } // giường
        public Guid? PrevID { get; set; } // mã điều trị chuyển đến (điều trị trước đó)
        
        public bool IsHopitalized { get; set; } // là khoa nhập viện điều trị

        public string InIcdCode { get; set; } // chẩn đoán vào viện
        public string InIcdName { get; set; } // tên chẩn đoán vào viện
        public string InIcdSubCode { get; set; } // chẩn đoán kèm theo
        public string InIcdText { get; set; } // tên chẩn đoán kèm theo
        public string InTraditionalIcdCode { get; set; } // chẩn đoán viện YHCT
        public string InTraditionalIcdName { get; set; } // tên chẩn đoán vào viện YHCT
        public string InTraditionalIcdSubCode { get; set; } // danh sách chẩn đoán kèm theo YHCT
        public string InTraditionalIcdText { get; set; } // danh sách tên chẩn đoán kèm theo YHCT

        public string IcdCode { get; set; } // chẩn đoán
        public string IcdName { get; set; } // tên chẩn đoán
        public string IcdText { get; set; } // chẩn đoán kèm theo
        public string TraditionalIcdCode { get; set; } // chẩn đoán YHCT
        public string TraditionalIcdName { get; set; } // tên chẩn đoán YHCT
        public string TraditionalIcdText { get; set; } // chẩn đoán kèm theo YHCT

        public int TreatmentResultID { get; set; } // kết quả điều trị
        public int TreatmentEndTypeID { get; set; } // hình thức xử trí

        public Treatment() { }
    }
}
