using HIS.EntityFrameworkCore.BaseEntitys;
using HIS.EntityFrameworkCore.Entities.Categories;
using System.ComponentModel;

namespace HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.ImpMests
{
    public class DImpMestMedicine : Entity<Guid>
    {
        [Description("Thứ tự sắp xếp")]
        public int? SortOrder { get; set; }

        [Description("Thuốc")]
        public Guid? MedicineId { get; set; }

        [Description("Giá nhập")]
        public decimal? ImpPrice { get; set; }

        [Description("Số lượng nhập")]
        public decimal? ImpQuantity { get; set; }

        [Description("Phần trăm vat giá nhập")]
        public decimal? ImpVatRate { get; set; }

        [Description("Phần trăm thuế")]
        public decimal? TaxRate { get; set; }

        public Guid? ImMestId { get; set; }

        public DImpMest DImMest { get; set; }
        public SMedicine SMedicine { get; set; }
    }
}
