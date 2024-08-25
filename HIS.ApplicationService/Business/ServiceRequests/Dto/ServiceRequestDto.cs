using HIS.Core.Application.Services.Dto;
using HIS.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.ServiceRequests.Dto
{
    public class ServiceRequestDto : EntityDto<Guid>
    {
        public string ServiceRequestCode { get; set; }
        public DateTime? RequestTime { get; set; } // ngày chỉ định (tạo phiếu)
        public DateTime? UseTime { get; set; } // ngày y lệnh
        public DateTime? SampleTime { get; set; } // thời gian lấy mẫu bệnh phẩm
        public DateTime? SampleReceivingTime { get; set; } // thời gian tiếp nhận mẫu
        public DateTime? StartTime { get; set; } // Ngày bắt đầu
        public DateTime? EndTime { get; set; } // Ngày kết thúc
        public string Barcode { get; set; }
        public int NumOrder { get; set; } // số thứ tự chỉ định trong ngày (số thứ tự thực hiện)
        public bool IsPriority { get; set; } // ưu tiên
        public string IcdCode { get; set; } // chẩn đoán
        public string IcdName { get; set; } // tên chẩn đoán
        public string IcdSubCode { get; set; } // bệnh kèm theo
        public string IcdText { get; set; } // danh sách bệnh kèm theo
        public int ServiceRequestTypeId { get; set; } // loại dịch vụ
        public Guid? PatientRecordId { get; set; }
        public Guid? MedicalRecordId { get; set; }
        public Guid? TreatmentId { get; set; }
        public Guid? DepartmentId { get; set; } // khoa chỉ định
        public Guid? RoomId { get; set; } // phòng chỉ định
        public Guid? UserId { get; set; } // người chỉ định
        public Guid? SampleUserId { get; set; } // người lấy mẫu
        public Guid? SampleReceivingUserId { get; set; } // người tiếp nhận mẫu
        public Guid? StartUserId { get; set; } // người bắt đầu
        public Guid? EndUserId { get; set; } // người kết thúc (trả kết quả)
        public Guid? ExecuteDepartmentId { get; set; } // khoa thực hiện
        public Guid? ExecuteRoomId { get; set; } // phòng thực hiện
        public ServiceRequestStatusTypes Status { get; set; } // trạng thái
    }
}
