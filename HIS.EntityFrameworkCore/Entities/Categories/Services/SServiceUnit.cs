using HIS.EntityFrameworkCore.BaseEntitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class SServiceUnit : Entity<Guid>
    {
        [Description("Mã ĐVT")]
        public string Code { get; set; }

        [Description("Tên ĐVT")]
        public string Name { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SoftOrder { get; set; }

        [Description("Đang sử dụng")]
        public bool? IsActive { get; set; }

        public IList<SServiceType>? SServiceTypes { get; set; }
        public IList<SService>? SServices { get; set; }
        public IList<SMedicineType>? SMedicineTypes { get; set; }
        public IList<SMedicine>? SMedicines { get; set; }

        public IList<SMaterial>? SMaterials { get; set; }
        public IList<SMaterialType>? SMaterialTypes { get; set; }
    }
}
