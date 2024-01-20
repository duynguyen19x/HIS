using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
using System.ComponentModel;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class ItemType : FullAuditedEntity<Guid>
    {
        [Description("Mã loại thuốc")]
        public string Code { get; set; }

        [Description("Mã BH")]
        public string HeInCode { get; set; }

        [Description("Tên loại thuốc")]
        public string Name { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SortOrder { get; set; }

        [Description("Đường dùng thuốc")]
        public Guid? ItemLineId { get; set; }

        [Description("Nhóm BHYT")]
        public Guid? ServiceGroupHeInId { get; set; }

        [Description("Nhóm thuốc")]
        public Guid? ItemGroupId { get; set; }

        [Description("Đơn vị tính")]
        public Guid? UnitId { get; set; }

        [Description("Hướng dẫn")]
        public string Tutorial { get; set; }

        [Description("Hoạt chất")]
        public string ActiveSubstance { get; set; }

        [Description("Nồng độ")]
        public string Concentration { get; set; }

        [Description("Hàm lượng")]
        public string Content { get; set; }

        [Description("Nước sản xuất")]
        public Guid? CountryId { get; set; }

        [Description("Hãng sản xuất")]
        public string Manufacturer { get; set; }

        [Description("Số đăng ký")]
        public string RegistrationNumber { get; set; }

        [Description("Biệt dược")]
        public string ProprietaryDrug { get; set; }

        [Description("Quy cách đóng gói")]
        public string PackagingSpecifications { get; set; }

        [Description("Giá nhập")]
        public decimal? ImpPrice { get; set; }

        [Description("Phần trăm vat giá nhập")]
        public decimal? ImpVatRate { get; set; }

        [Description("Phần trăm thuế")]
        public decimal? ImpTaxRate { get; set; }

        [Description("Diễn giải")]
        public string Description { get; set; }

        [Description("Ngưng sử dụng")]
        public bool Inactive { get; set; }

        [Description("Thuốc kháng sinh")]
        public bool IsAntibiotics { get; set; }

        [Description("Thuốc tân dược")]
        public bool IsNewDrug { get; set; }

        [Description("Thuốc kê đơn")]
        public bool IsPrescriptionDrug { get; set; }

        [Description("Dược phẩm chức năng")]
        public bool IsNutraceutical { get; set; }

        [Description("Thuốc Tài trợ")]
        public bool IsSponsoredDrug { get; set; }

        [Description("Thuốc khí dung")]
        public bool IsInhalantDrug { get; set; }

        [Description("Thuốc kê đơn trẻ em")]
        public bool IsPrescriptionDrugForChildren { get; set; }

        [Description("Vị thuốc YHCT")]
        public bool IsTraditionalHerbalDrug { get; set; }

        [Description("Chế phẩm YHCT")]
        public bool IsTraditionalDrugFormulation { get; set; }

        [Description("YC trả lại vỏ thuốc")]
        public bool IsDrugContainerReturnRequest { get; set; }

        [Description("Cho phép kê SL bằng 0")]
        public bool IsAllowZeroQuantity { get; set; }

        [Description("Thuốc phóng xạ")]
        public bool IsRadiolabeledDrug { get; set; }

        // Thông tin khác
        [Description("Dạng bào chế")]
        public string PharmaceuticalFormulation { get; set; }

        [Description("Nguồn gốc")]
        public string Origin { get; set; }

        [Description("Tên khoa học vị thuốc")]
        public string ScientificName { get; set; }

        [Description("Tên KH của cây con, khoáng vật")]
        public string ScientificNameChildren { get; set; }

        [Description("Tình trạng dược liệu")]
        public string DugStatus { get; set; }

        [Description("Yêu cầu sử dụng dược liệu")]
        public string RequirementUseDug { get; set; }

        [Description("Bộ phận dược liệu sử dụng")]
        public string PharmaceuticalDivision { get; set; }

        [Description("Tỷ lệ hao hụt chế biến")]
        public string ProcessingLossRate { get; set; }

        [Description("Chi phí khác")]
        public decimal? OtherExpenses { get; set; }

        [Description("Phương pháp chế biến")]
        public string PreparationMethod { get; set; }

        [Description("Tiêu chuẩn chất lượng")]
        public string QualityStandards { get; set; }

        [Description("Đánh số lô")]
        public int AutoNumber { get; set; }

        [Description("Loại hàng hóa")]
        public CommodityTypes CommodityType { get; set; }

        public Unit Unit { get; set; }
        public ItemLine ItemLine { get; set; }
        public ItemGroup ItemGroup { get; set; }
        public Country Country { get; set; }
    }
}
