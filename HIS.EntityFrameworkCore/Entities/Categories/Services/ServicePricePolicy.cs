using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;

namespace HIS.EntityFrameworkCore.Entities.Categories.Services
{
    public class ServicePricePolicy : FullAuditedEntity<Guid>
    {
        public Guid? ServiceId { get; set; }
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

        public Service Service { get; set; }
        public PatientType PatientType { get; set; }
    }
}
