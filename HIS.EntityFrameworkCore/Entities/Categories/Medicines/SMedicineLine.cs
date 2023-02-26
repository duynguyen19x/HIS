using HIS.EntityFrameworkCore.BaseEntitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class SMedicineLine : Entity<Guid>
    {
        [Description("Mã đường dùng thuốc")]
        public string? Code { get; set; }

        [Description("Tên đường dùng thuốc")]
        public string? Name { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SoftOrder { get; set; }

        public IList<SMedicineType>? SMedicineTypes { get; set; }
        public IList<SMedicine>? SMedicines { get; set; }
    }
}
