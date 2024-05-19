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
    public class Order : AuditedEntity<Guid>
    {
        public string OrderCode { get; set; } // mã phiếu chỉ định
        public DateTime OrderDate { get; set; } // ngày y lệnh
        public int OrderTypeID { get; set; }  // loại phiếu
        public int OrderStatusID { get; set; } // trạng thái
        public int NumOrder { get; set; } // số thứ tự phiếu chỉ định theo ngày y lệnh và loại phiếu
        public string Barcode { get; set; }
        public Guid MedicalRecordID { get; set; } // mã bệnh án
        public Guid TreatmentID { get; set; } // mã điều trị
        public Guid? ReceptionID { get; set; } // mã đăng ký khám (phiếu được chỉ định từ phòng tiếp đón)
        public Guid? InsuranceID { get; set; } // mã bhyt
        public Guid UserID { get; set; } // người chỉ định
        public Guid BranchID { get; set; } // chi nhánh làm việc
        public Guid DepartmentID { get; set; } // khoa chỉ định
        public Guid RoomID { get; set; } // phòng chỉ định
        public DateTime? SampleStartDate { get; set; } // thời gian bắt đầu lấy mẫu bệnh phẩm
        public DateTime? SampleEndDate { get; set; } // thời gian kết thúc lấy mẫu bệnh phẩm
        public Guid? SampleUserID { get; set; } // người thực hiện lấy mẫu bệnh phẩm
        public Guid? SampleDepartmentID { get; set; } // khoa thực hiện lấy mẫu bệnh phẩm
        public Guid? SampleRoomID { get; set; } // phòng thực hiện lấy mẫu bệnh phẩm
        public DateTime? ReceiveDate { get; set; } // thời gian tiếp nhân
        public Guid? ReceiveUserID { get; set; } // người tiếp nhận yêu cầu
        public DateTime? ExecuteDate { get; set; } // thời gian thực hiện
        public Guid? ExecuteUserID { get; set; } // người thực hiện
        public Guid? ExecuteDepartmentID { get; set; } // khoa thực hiện
        public Guid? ExecuteRoomID { get; set; } // phòng thực hiện
        public DateTime? EndDate { get; set; } // ngày trả kết quả
        public Guid? EndUserID { get; set; } // người trả kết quả
        public string IcdCode { get; set; } // mã chẩn đoán 
        public string IcdName { get; set; } // chẩn đoán
        public string IcdSubCode { get; set; } // mã bệnh kèm theo
        public string IcdText { get; set; } // tên mã bệnh kèm theo
        public bool IsEmergency { get; set; } // cấp cứu


        //[ForeignKey(nameof(BranchID))]
        //public virtual Branch BranchFk { get; set; }

        //[ForeignKey(nameof(DepartmentID))]
        //public virtual Department DepartmentFk { get; set; }
    }
}
