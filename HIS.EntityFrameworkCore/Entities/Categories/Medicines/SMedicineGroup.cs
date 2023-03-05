using HIS.EntityFrameworkCore.BaseEntitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class SMedicineGroup : Entity<Guid>
    {
        [Description("Mã nhóm thuốc")]
        public string Code { get; set; }

        [Description("Tên nhóm thuốc")]
        public string Name { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SoftOrder { get; set; }

        public IList<SMaterialType>? SMedicineTypes { get; set; }
    }
}
