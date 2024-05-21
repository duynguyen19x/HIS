using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Hóa đơn thanh toán
    /// </summary>
    public class Invoice : AuditedEntity<Guid>
    {
        public string InvoiceCode { get; set; }

        public DateTime InvoiceDate { get; set; }

        public int InvoiceTypeID { get; set; } // loại phiếu thu

        public Guid InvoiceGroupID { get; set; } // sổ phiếu thu

        public Guid PaymentMethodID { get; set; } // hình thức thanh toán

        public Guid MedicalRecordID { get; set; }

        public Guid TreatmentID { get; set; }

        public Guid UserID { get; set; }

        public Guid BranchID { get; set; }

        public Guid DepartmentID { get; set; }

        public Guid RoomID { get; set; }

        public decimal Amount { get; set; }


        public bool IsDeleted { get; set; } // đã xóa

        public DateTime? DeletedDate { get; set; } // ngày xóa

        public Guid? DeletedBy { get; set; } // người xóa

    }
}
