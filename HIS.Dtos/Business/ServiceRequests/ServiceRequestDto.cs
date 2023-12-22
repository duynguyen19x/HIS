using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.ServiceRequestDatas;

namespace HIS.Dtos.Business.ServiceRequests
{
    public class ServiceRequestDto : EntityDto<Guid>
    {
        public string ServiceRequestCode { get; set; }
        public DateTime ServiceRequestDate { get; set; } // ngày chỉ định (tạo phiếu)
        public DateTime ServiceRequestUseDate { get; set; } // ngày y lệnh
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
        public Guid ExecuteDepartmentId { get; set; } // khoa thực hiện
        public Guid ExecuteRoomId { get; set; } // phòng thực hiện
        public Guid? ExecuteUserId { get; set; } // người thực hiện


        public IList<ServiceRequestDataDto> ServiceRequestDatas { get; set; }
    }
}
