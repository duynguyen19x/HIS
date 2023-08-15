using HIS.Core.Entities;
using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Business.Patients;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories.Medicines
{
    public class SMedicinePricePolicy : FullAuditedEntity<Guid>
    {
        public int? PatientTypeId { get; set; }

        /// <summary>
        /// Giá cữ
        /// </summary>
        public decimal? OldUnitPrice { get; set; }

        /// <summary>
        /// Giá mới
        /// </summary>
        public decimal? NewUnitPrice { get; set; }

        /// <summary>
        /// Trần BH
        /// </summary>
        public decimal? CeilingPrice { get; set; }

        /// <summary>
        /// Tỷ lệ thanh toán
        /// </summary>
        public decimal? PaymentRate { get; set; }

        /// <summary>
        /// Ngày áp dụng giá mới
        /// </summary>
        public DateTime? ExecutionTime { get; set; }

        /// <summary>
        /// Thuốc
        /// </summary>
        public Guid? MedicineId { get; set; }

        public SMedicine SMedicine { get; set; }
        public SPatientType SPatientType { get; set; }
    }
}
