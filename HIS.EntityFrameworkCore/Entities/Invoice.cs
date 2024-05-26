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

        public int InvoiceTypeId { get; set; } // loại phiếu thu

        public Guid InvoiceGroupId { get; set; } // sổ phiếu thu

        public Guid PaymentMethodId { get; set; } // hình thức thanh toán

        public Guid MedicalRecordId { get; set; }

        public Guid TreatmentId { get; set; }

        public Guid UserId { get; set; }

        public Guid BranchId { get; set; }

        public Guid DepartmentId { get; set; }

        public Guid RoomId { get; set; }

        public decimal Amount { get; set; }


        public bool IsDeleted { get; set; } // đã xóa

        public DateTime? DeletedDate { get; set; } // ngày xóa

        public Guid? DeletedBy { get; set; } // người xóa

    }
}
