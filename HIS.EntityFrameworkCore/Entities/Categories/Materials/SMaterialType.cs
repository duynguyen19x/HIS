using HIS.EntityFrameworkCore.BaseEntitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class SMaterialType : FullAuditingEntity<Guid>
    {
        [Description("Mã loại VT")]
        public string Code { get; set; }

        [Description("Tên loại VT")]
        public string Name { get; set; }

        [Description("Id service")]
        public Guid? ServiceId { get; set; }

        [Description("Id cha")]
        public Guid? ParentId { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SoftOrder { get; set; }

        [Description("Đơn vị tính")]
        public Guid? ServiceUnitId { get; set; }

        [Description("Hướng dẫn")]
        public string Tutorial { get; set; }

        [Description("Nước sản xuất")]
        public Guid? NationalId { get; set; }

        [Description("Giá nhập")]
        public decimal? ImpPrice { get; set; }

        [Description("Phần trăm vat giá nhập")]
        public decimal? ImpVatRate { get; set; }

        [Description("Giá nội bộ")]
        public decimal? InternalPrice { get; set; }

        [Description("Diễn giải")]
        public string Description { get; set; }

        [Description("Đang sử dụng")]
        public bool? IsActive { get; set; }

        public SService SService { get; set; }
        public SServiceUnit SServiceUnit { get; set; }
        public IList<SMaterial> SMaterials { get; set; }
    }
}
