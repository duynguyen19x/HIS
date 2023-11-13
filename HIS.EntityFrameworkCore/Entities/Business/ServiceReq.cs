using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    public class ServiceReq : FullAuditedEntity<Guid>
    {
        public virtual string Code { get; set; } // số phiếu
        public virtual DateTime ReqDate { get; set; } // thời gian chỉ đinh
        public virtual DateTime UseDate { get; set; } // thời gian y lệnh
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual Guid UserId { get; set; } // người chỉ định
        public virtual Guid DepartmentId { get; set; } // khoa chỉ định
        public virtual Guid RoomId { get; set; } // phòng chỉ đinh
        public virtual Guid PatientRecordId { get; set; } // mã hồ sơ bệnh án
        public virtual Guid MedicalRecordId { get; set; } // mã bệnh án
        public virtual Guid TreatmentId { get; set; } // tờ điều trị
        public virtual string ICDCode { get; set; } // mã chẩn đoán
        public virtual string ICDName { get; set; } // tên chẩn đoán
        public virtual string ICDSubCode { get; set; } // mã bệnh phụ
        public virtual string ICDText { get; set; } // danh sách mã bệnh kèm theo
        public virtual string SortOrder { get; set; } // số thứ tự
        public virtual string Description { get; set; } // ghi chú
    }
}
