using HIS.Dtos.Base;
using HIS.Dtos.Dictionaries.Medicine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.MedicineType
{
    public class SMedicineTypeDto: EntityDto<Guid?>
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
        public Guid? MedicineLineId { get; set; }

        [Description("Nhóm thuốc")]
        public Guid? MedicineGroupId { get; set; }

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

        [Description("Quy cách đóng gói")]
        public string PackagingSpecifications { get; set; }

        [Description("Giá nhập")]
        public decimal? ImpPrice { get; set; }

        [Description("Phần trăm vat giá nhập")]
        public decimal? ImpVatRate { get; set; }

        [Description("Phần trăm thuế")]
        public decimal? TaxRate { get; set; }

        [Description("Diễn giải")]
        public string Description { get; set; }

        [Description("Liều dùng")]
        public string Dosage { get; set; }

        [Description("Ngưng sử dụng")]
        public bool Inactive { get; set; }

        public IList<SMedicineDto> SMedicines { get; set; }
    }
}
