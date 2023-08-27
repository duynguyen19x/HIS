using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Systems;
using HIS.Utilities.Enums;

namespace HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals
{
    public class InOutStock : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// Mã phiếu
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Trạng thái phiếu
        /// </summary>
        public InOutStatusType Status { get; set; }

        /// <summary>
        /// Loại phiếu: 0 - Nhập, 1 - xuất
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// Kho nhập
        /// </summary>
        public Guid? ImpStockId { get; set; }

        /// <summary>
        /// Kho xuất
        /// </summary>
        public Guid? ExpStockId { get; set; }

        /// <summary>
        /// Loại phiếu nhập, xuất
        /// </summary>
        public int? InOutStockTypeId { get; set; }

        /// <summary>
        /// Người nhận
        /// </summary>
        public Guid? ReceiverUserId { get; set; }

        /// <summary>
        /// Người duyệt
        /// </summary>
        public Guid? ApproverUserId { get; set; }

        /// <summary>
        /// Ngày duyệt
        /// </summary>
        public DateTime? ApproverTime { get; set; }

        /// <summary>
        /// Ngày tạo phiếu, yêu cầu
        /// </summary>
        public DateTime? ReqTime { get; set; }

        /// <summary>
        /// Người tạo phiếu nhập
        /// </summary>
        public Guid? CreationUserId { get; set; }

        /// <summary>
        /// Ngày nhập kho
        /// </summary>
        public DateTime? StockImpTime { get; set; }

        /// <summary>
        /// Người nhập kho
        /// </summary>
        public Guid? StockImpUserId { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Phòng yêu cầu
        /// </summary>
        public Guid? ReqRoomId { get; set; }

        /// <summary>
        /// Khoa yêu cầu
        /// </summary>
        public Guid? ReqDepartmentId { get; set; }

        /// <summary>
        /// Id Bệnh nhân
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Id điều trị
        /// </summary>
        public Guid? PatientRecordId { get; set; }

        /// <summary>
        /// Nhà cung cấp
        /// </summary>
        public Guid? SupplierId { get; set; }

        /// <summary>
        /// Ngày hóa đơn
        /// </summary>
        public DateTime? InvTime { get; set; }

        /// <summary>
        /// Số hóa đơn
        /// </summary>
        public string InvNo { get; set; }

        /// <summary>
        /// NGười giao
        /// </summary>
        public string Deliverer { get; set; }

        /// <summary>
        /// Ngày xuất kho
        /// </summary>
        public DateTime? StockExpTime { get; set; }

        /// <summary>
        /// Người xuất kho
        /// </summary>
        public Guid? StockExpUserId { get; set; }

        public Room ImpStock { get; set; }
        public Room ExpStock { get; set; }
        public InOutStockType InOutStockType { get; set; }
        public User CreationUser { get; set; }
        public User ReceiverUser { get; set; }
        public User ApproverUser { get; set; }
        public User StockImpUser { get; set; }
        public User StockExpUser { get; set; }
        public Room ReqRoom { get; set; }
        public Department ReqDepartment { get; set; }
        public Supplier Supplier { get; set; }

        public Patient Patient { get; set; }
        public PatientRecord PatientRecord { get; set; }
    }
}
