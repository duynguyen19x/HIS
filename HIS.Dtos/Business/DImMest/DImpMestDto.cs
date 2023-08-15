using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Business.DImMestMedicine;
using HIS.Utilities.Enums;

namespace HIS.Dtos.Business.DImMest
{
    public class DImpMestDto : EntityDto<Guid?>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public ImpMestStatusType ImpMestStatus { get; set; }

        /// <summary>
        /// Kho nhập
        /// </summary>
        public Guid? ImStockId { get; set; }
        public string ImStockCode { get; set; }
        public string ImStockName { get; set; }

        /// <summary>
        /// Kho xuất
        /// </summary>
        public Guid? ExStockId { get; set; }
        public string ExStockCode { get; set; }
        public string ExStockName { get; set; }

        /// <summary>
        /// Loại phiếu nhập, xuất
        /// </summary>
        public int? ImpExpMestTypeId { get; set; }
        public string ImpExpMestTypeName { get; set; }

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
        public DateTime? StockReceiptTime { get; set; }

        /// <summary>
        /// Người nhập kho
        /// </summary>
        public Guid? StockReceiptUserId { get; set; }

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
        /// Id điều trị
        /// </summary>
        public Guid? TreatmentId { get; set; }

        /// <summary>
        /// Id Bệnh nhân
        /// </summary>
        public Guid? PatientId { get; set; }

        /// <summary>
        /// Nhà cung cấp
        /// </summary>
        public Guid? SupplierId { get; set; }

        /// <summary>
        /// Ngày hóa đơn
        /// </summary>
        public DateTime? InvTime { get; set; }

        /// <summary>
        /// NGười giao
        /// </summary>
        public string Deliverer { get; set; }

        public IList<DImpMestMedicineDto> DImpMestMedicines { get; set; }
    }
}
