using HIS.EntityFrameworkCore.BaseEntitys;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class SMaterial : FullAuditingEntity<Guid>
    {
        [Description("Mã VT")]
        public string Code { get; set; }

        [Description("Tên VT")]
        public string Name { get; set; }

        [Description("Id service")]
        public Guid? ServiceId { get; set; }

        [Description("Id cha")]
        public Guid? ParentId { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SoftOrder { get; set; }

        [Description("Nhóm VT")]
        public Guid? MaterialTypeId { get; set; }

        [Description("Đơn vị tính")]
        public Guid? UnitId { get; set; }

        [Description("Nước sản xuất")]
        public Guid? NationalId { get; set; }

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

        [Description("Ngưng sử dụng")]
        public bool Inactive { get; set; }

        public SService SService { get; set; }
        public SMaterialType SMaterialType { get; set; }
        public SUnit SUnit { get; set; }
    }
}
