using HIS.Core.Entities;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.DImpMests;
using HIS.EntityFrameworkCore.Entities.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.DExpMests
{
    public class DExpMestMedicine : Entity<Guid>
    {
        [Description("Thứ tự sắp xếp")]
        public int? SortOrder { get; set; }

        [Description("Thuốc")]
        public Guid? MedicineId { get; set; }

        [Description("Giá nhập")]
        public decimal? ImpPrice { get; set; }

        [Description("Số lượng nhập")]
        public decimal? ExpQuantity { get; set; }

        [Description("Phần trăm vat giá nhập")]
        public decimal? ImpVatRate { get; set; }

        [Description("Phần trăm thuế")]
        public decimal? TaxRate { get; set; }

        /// <summary>
        /// Phiếu nhập
        /// </summary>
        public Guid? ExpMestId { get; set; }

        public DImpMest DExpMest { get; set; }
        public SMedicine SMedicine { get; set; }
    }
}
