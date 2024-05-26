using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Phiếu chỉ định dịch vụ
    /// </summary>
    [Table("DOrder")]
    public class Order : AuditedEntity<Guid>
    {
        public string OrderCode { get; set; } // mã phiếu chỉ định

        public DateTime OrderDate { get; set; } // ngày y lệnh

        public int OrderTypeId { get; set; }  // loại phiếu

        public int OrderStatusId { get; set; } // trạng thái

        public int NumOrder { get; set; } // số thứ tự phiếu chỉ định theo ngày y lệnh và loại phiếu

        public string Barcode { get; set; }

        public Guid MedicalRecordId { get; set; } // mã bệnh án

        public Guid TreatmentId { get; set; } // mã điều trị

        public Guid? ReceptionId { get; set; } // mã đăng ký khám (phiếu được chỉ định từ phòng tiếp đón)

        public Guid? InsuranceId { get; set; } // mã bhyt

        public Guid UserId { get; set; } // người chỉ định

        public Guid BranchId { get; set; } // chi nhánh làm việc

        public Guid DepartmentId { get; set; } // khoa chỉ định

        public Guid RoomId { get; set; } // phòng chỉ định

        public DateTime? SampleStartDate { get; set; } // thời gian bắt đầu lấy mẫu bệnh phẩm

        public DateTime? SampleEndDate { get; set; } // thời gian kết thúc lấy mẫu bệnh phẩm

        public Guid? SampleUserId { get; set; } // người thực hiện lấy mẫu bệnh phẩm

        public Guid? SampleDepartmentId { get; set; } // khoa thực hiện lấy mẫu bệnh phẩm

        public Guid? SampleRoomId { get; set; } // phòng thực hiện lấy mẫu bệnh phẩm

        public DateTime? ReceiveDate { get; set; } // thời gian tiếp nhân

        public Guid? ReceiveUserId { get; set; } // người tiếp nhận yêu cầu

        public DateTime? ExecuteDate { get; set; } // thời gian thực hiện

        public Guid? ExecuteUserId { get; set; } // người thực hiện

        public Guid? ExecuteDepartmentId { get; set; } // khoa thực hiện

        public Guid? ExecuteRoomId { get; set; } // phòng thực hiện

        public DateTime? EndDate { get; set; } // ngày trả kết quả

        public Guid? EndUserId { get; set; } // người trả kết quả

        public string IcdCode { get; set; } // mã chẩn đoán 

        public string IcdName { get; set; } 

        public string IcdSubCode { get; set; } 

        public string IcdText { get; set; }

        public string TraditionalIcdCode { get; set; } // mã chẩn đoán theo BHYT

        public string TraditionalIcdName { get; set; }

        public string TraditionalIcdSubCode { get; set; }

        public string TraditionalIcdText { get; set; }

        public bool IsEmergency { get; set; } // cấp cứu

        public bool IsPriority { get; set; } // ưu tiên

        [ForeignKey(nameof(OrderTypeID))]
        public virtual OrderType OrderTypeFk { get; set; }


    }
}
