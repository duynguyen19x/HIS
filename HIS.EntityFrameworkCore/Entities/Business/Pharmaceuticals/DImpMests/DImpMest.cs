using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.DExpMests;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Systems;
using HIS.Utilities.Enums;

namespace HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.DImpMests
{
    public class DImpMest : FullAuditedEntity<Guid>
    {
        public string Code { get; set; }

        /// <summary>
        /// Trạng thái phiếu nhập
        /// </summary>
        public ImpMestStatusType ImpMestStatus { get; set; }

        /// <summary>
        /// Trang thái phiếu xuất
        /// </summary>
        public ExpMestStatusType ExpMestStatus { get; set; }

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
        public int? ImpExpMestTypeId { get; set; }

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
        /// Ngày tạo phiếu nhập
        /// </summary>
        public DateTime? ImpTime { get; set; }

        /// <summary>
        /// Người tạo phiếu nhập
        /// </summary>
        public Guid? ImpUserId { get; set; }

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
        /// Phiếu xuất
        /// </summary>
        public Guid? ExpMestId { get; set; }

        public DExpMest DExpMest { get; set; }
        public SRoom ImpStock { get; set; }
        public SRoom ExpStock { get; set; }
        public DImpExpMestType DImpExpMestType { get; set; }
        public SUser ReceiverUser { get; set; }
        public SUser ApproverUser { get; set; }
        public SUser StockImpUser { get; set; }
        public SRoom ReqRoom { get; set; }
        public SDepartment ReqDepartment { get; set; }
        public SSupplier SSupplier { get; set; }

        public HISPatient Patient { get; set; }
        public HISPatientRecord PatientRecord { get; set; }
    }
}
