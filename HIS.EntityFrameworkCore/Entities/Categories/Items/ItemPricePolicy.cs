using HIS.Core.Domain.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Categories.Items
{
    public class ItemPricePolicy : FullAuditedEntity<Guid>
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
        public Guid? ItemId { get; set; }

        public Item Item { get; set; }

        public PatientObjectType PatientType { get; set; }
    }
}
