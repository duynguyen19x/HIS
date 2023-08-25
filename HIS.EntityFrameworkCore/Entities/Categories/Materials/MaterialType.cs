﻿using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class MaterialType : FullAuditedEntity<Guid>
    {
        [Description("Mã loại VT")]
        public string Code { get; set; }

        [Description("Tên loại VT")]
        public string Name { get; set; }

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

        [Description("Ngưng sử dụng")]
        public bool Inactive { get; set; }

        public Unit SUnit { get; set; }
        public IList<Material> SMaterials { get; set; }
    }
}