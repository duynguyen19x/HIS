using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Business.Patients;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.DImpMests;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Systems;
using HIS.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.DExpMests
{
    public class DExpMest : FullAuditedEntity<Guid>
    {
        public string Code { get; set; }

        /// <summary>
        /// Trạng thái phiếu nhập
        /// </summary>
        public ImpMestStatusType ImpMestStatus { get; set; }

        /// <summary>
        /// Trang thái phiếu xuất
        /// </summary>
        public EmpMestStatusType ExpMestStatus { get; set; }

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
        /// Người duyệt
        /// </summary>
        public Guid? ApproverUserId { get; set; }

        /// <summary>
        /// Ngày duyệt
        /// </summary>
        public DateTime? ApproverTime { get; set; }

        /// <summary>
        /// Ngày tạo phiếu xuất
        /// </summary>
        public DateTime? ExpTime { get; set; }

        /// <summary>
        /// Người tạo phiếu nhập
        /// </summary>
        public Guid? ExpUserId { get; set; }

        /// <summary>
        /// Ngày nhập kho
        /// </summary>
        public DateTime? StockExpTime { get; set; }

        /// <summary>
        /// Người nhập kho
        /// </summary>
        public Guid? StockExpUserId { get; set; }

        /// <summary>
        /// Nội dung
        /// </summary>
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

        public Guid? ImpMestId { get; set; }

        public DImpMest DImpMest { get; set; }
        public SRoom ImpStock { get; set; }
        public SRoom ExpStock { get; set; }
        public DImpExpMestType DImpExpMestType { get; set; }
        public SUser ReceiverUser { get; set; }
        public SUser ApproverUser { get; set; }
        public SUser StockExpUser { get; set; }
        public SRoom ReqRoom { get; set; }
        public SDepartment ReqDepartment { get; set; }
        public STreatment STreatment { get; set; }
        public SPatient SPatient { get; set; }
        public SSupplier SSupplier { get; set; }
    }
}
