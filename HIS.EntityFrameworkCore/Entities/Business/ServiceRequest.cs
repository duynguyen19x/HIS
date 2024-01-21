﻿using HIS.Core.Domain.Entities.Auditing;
using HIS.Utilities.Enums;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    public class ServiceRequest : FullAuditedEntity<Guid>
    {
        public string ServiceRequestCode { get; set; }
        public long ServiceRequestDate { get; set; } // ngày chỉ định (tạo phiếu)
        public long ServiceRequestUseDate { get; set; } // ngày y lệnh
        public long StartTime { get; set; }
        public long EndTime { get; set; }
        public string Barcode { get; set; }
        public int NumOrder { get; set; } // số thứ tự chỉ định trong ngày (số thứ tự thực hiện)
        public bool IsPriority { get; set; } // ưu tiên
        public string IcdCode { get; set; } // chẩn đoán
        public string IcdName { get; set; } // tên chẩn đoán
        public string IcdSubCode { get; set; } // bệnh kèm theo
        public string IcdText { get; set; } // danh sách bệnh kèm theo
        public int ServiceRequestTypeId { get; set; } // loại dịch vụ
        public int ServiceRequestStatusId { get; set; } // trạng thái
        public Guid PatientRecordId { get; set; }
        public Guid MedicalRecordId { get; set; }
        public Guid? TreatmentId { get; set; }
        public Guid DepartmentId { get; set; } // khoa chỉ định
        public Guid RoomId { get; set; } // phòng chỉ định
        public Guid UserId { get; set; } // người chỉ định
        public Guid? StartUserId { get; set; } // người bắt đầu
        public Guid? EndUserId { get; set; } // người kết thúc (trả kết quả)
        public Guid ExecuteDepartmentId { get; set; } // khoa thực hiện
        public Guid ExecuteRoomId { get; set; } // phòng thực hiện
        public Guid? ExecuteUserId { get; set; } // người thực hiện
        public ServiceRequestStatusTypes Status { get; set; } // trạng thái
    }
}
