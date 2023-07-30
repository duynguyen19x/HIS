using HIS.EntityFrameworkCore.BaseEntitys;
using HIS.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.ImpMests
{
    public class DImMest : FullAuditingEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public ImMestStatusType ImMestStatus { get; set; }
        /// <summary>
        /// Kho nhập
        /// </summary>
        public Guid? ImStockId { get; set; }
        /// <summary>
        /// Kho xuất
        /// </summary>
        public Guid? ExStockId { get; set; }
        /// <summary>
        /// Loại phiếu nhập, xuất
        /// </summary>
        public int? ImExMestTypeId { get; set; }
        /// <summary>
        /// Người nhận, người nhập
        /// </summary>
        public Guid? ReceiverUserId { get; set; }
        /// <summary>
        /// NGười duyệt
        /// </summary>
        public Guid? ApproverUserId { get; set; }
        /// <summary>
        /// Thời gian nhập, ngày tạo phiếu nhập
        /// </summary>
        public DateTime? ImpTime { get; set; }
        /// <summary>
        /// Ngày duyệt, ngày nhập kho
        /// </summary>
        public DateTime? ApproverTime { get; set; }
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
    }
}
