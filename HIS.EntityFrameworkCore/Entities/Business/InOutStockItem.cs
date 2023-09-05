using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities;
using HIS.EntityFrameworkCore.Entities.Categories;
using System.ComponentModel;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    public class InOutStockItem : Entity<Guid>
    {
        public Guid? InOutStockId { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SortOrder { get; set; }

        [Description("Thuốc")]
        public Guid? ItemId { get; set; }

        [Description("Giá nhập")]
        public decimal? ImpPrice { get; set; }

        [Description("Số lượng YC")]
        public decimal? RequestQuantity { get; set; }

        [Description("Số lượng duyệt")]
        public decimal? ApprovedQuantity { get; set; }

        [Description("Phần trăm vat giá nhập")]
        public decimal? ImpVatRate { get; set; }

        [Description("Phần trăm thuế")]
        public decimal? ImpTaxRate { get; set; }

        [Ignore]
        public InOutStock InOutStock { get; set; }
        [Ignore]
        public Item Item { get; set; }
    }
}
