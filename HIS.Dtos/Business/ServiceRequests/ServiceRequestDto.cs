using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Business.ServiceRequestDatas;
using HIS.Dtos.Business.ServiceResultDatas;
using HIS.Utilities.Enums;

namespace HIS.Dtos.Business.ServiceRequests
{
    public class ServiceRequestDto : EntityDto<Guid?>
    {
        public string ServiceRequestCode { get; set; }
        public long RequestTime { get; set; } // ngày chỉ định (tạo phiếu)
        public long UseTime { get; set; } // ngày y lệnh
        public long StartTime { get; set; } // Ngày bắt đầu
        public long EndTime { get; set; } // Ngày kết thúc
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
        public Guid? StartUserId { get; set; } // người bắt đầu thực hiện
        public Guid? EndUserId { get; set; } // người kết thúc (trả kết quả)
        public Guid ExecuteDepartmentId { get; set; } // khoa thực hiện
        public Guid ExecuteRoomId { get; set; } // phòng thực hiện

        public ServiceRequestStatusTypes Status { get; set; } // trạng thái

        public string UserCode { get; set; }
        public string UserName { get; set; }

        public string PatientCode { get; set; }
        public string PatientName { get; set; }

        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }

        public string RoomCode { get; set; }
        public string RoomName { get; set; }

        public string ExecuteRoomCode { get; set; }
        public string ExecuteRoomName { get; set; }

        public string StartUserCode { get; set; }
        public string StartUserName { get; set; }

        public string EndUserCode { get; set; }
        public string EndUserName { get; set; }

        public IList<ServiceRequestDataDto> ServiceRequestDatas { get; set; }
        public IList<ServiceResultDataDto> ServiceResultDatas { get; set; }
    }
}
