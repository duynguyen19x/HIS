using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Dictionaries.ItemPricePolicies;
using HIS.Utilities.Enums;
using System.ComponentModel;

namespace HIS.Dtos.Dictionaries.Items
{
    public class ItemDto : EntityDto<Guid?>
    {
        [Description("Mã thuốc")]
        public string Code { get; set; }

        [Description("Mã BH")]
        public string HeInCode { get; set; }

        [Description("Tên thuốc")]
        public string Name { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SortOrder { get; set; }

        [Description("Đường dùng thuốc")]
        public Guid? ItemLineId { get; set; }

        [Description("Nhóm thuốc")]
        public Guid? ItemGroupId { get; set; }

        [Description("Nhóm thuốc")]
        public Guid? ItemTypeId { get; set; }

        [Description("Đơn vị tính")]
        public Guid? UnitId { get; set; }

        [Description("Hướng dẫn")]
        public string Tutorial { get; set; }

        [Description("Nước sản xuất")]
        public Guid? CountryId { get; set; }

        [Description("Giá nhập")]
        public decimal? ImpPrice { get; set; }

        [Description("Số lượng nhập")]
        public decimal? ImpQuantity { get; set; }

        [Description("Phần trăm vat giá nhập")]
        public decimal? ImpVatRate { get; set; }

        [Description("Phần trăm thuế")]
        public decimal? ImpTaxRate { get; set; }

        [Description("Diễn giải")]
        public string Description { get; set; }

        [Description("Hoạt chất")]
        public string ActiveSubstance { get; set; }

        [Description("Nồng độ")]
        public string Concentration { get; set; }

        [Description("Hàm lượng")]
        public string Content { get; set; }

        [Description("Hãng sản xuất")]
        public string Manufacturer { get; set; }

        [Description("Quy cách đóng gói")]
        public string PackagingSpecifications { get; set; }

        [Description("Liều dùng")]
        public string Dosage { get; set; }

        [Description("Lô")]
        public string Lot { get; set; }

        [Description("Hạn dùng")]
        public DateTime? DueDate { get; set; }

        [Description("Quyệt định thầu")]
        public string TenderDecision { get; set; }

        [Description("Gói thầu")]
        public string TenderPackage { get; set; }

        [Description("Nhóm thầu")]
        public string TenderGroup { get; set; }

        [Description("Năm thầu")]
        public int? TenderYear { get; set; }

        [Description("Ngưng sử dụng")]
        public bool Inactive { get; set; }

        [Description("Loại hàng hóa")]
        public CommodityTypes CommodityType { get; set; }

        public IList<ItemPricePolicyDto> ItemPricePolicies { get; set; }
    }
}
