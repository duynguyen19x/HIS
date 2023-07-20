using HIS.EntityFrameworkCore.BaseEntitys;
using HIS.EntityFrameworkCore.Entities.Categories.Medicines;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class SMedicine : FullAuditingEntity<Guid>
    {
        [Description("Mã thuốc")]
        public string Code { get; set; }

        [Description("Tên thuốc")]
        public string Name { get; set; }

        //[Description("Id service")]
        //public Guid? ServiceId { get; set; }

        //[Description("Id cha")]
        //public Guid? ParentId { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SoftOrder { get; set; }

        [Description("Đường dùng thuốc")]
        public Guid? MedicineLineId { get; set; }

        [Description("Nhóm thuốc")]
        public Guid? MedicineGroupId { get; set; }

        [Description("Nhóm thuốc")]
        public Guid? MedicineTypeId { get; set; }

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
        public decimal? TaxRate { get; set; }

        [Description("Giá nội bộ")]
        public decimal? InternalPrice { get; set; }

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

        [Description("Ngưng sử dụng")]
        public bool Inactive { get; set; }

        //public SService SService { get; set; }
        public SMedicineType SMedicineType { get; set; }
        public SUnit SUnit { get; set; }
        public SMedicineLine SMedicineLine { get; set; }
        public SCountry SCountry { get; set; }
        public IList<SMedicinePricePolicy> SMedicinePricePolicies { get; set; }
    }
}
