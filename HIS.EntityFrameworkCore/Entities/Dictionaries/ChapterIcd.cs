using HIS.Core.Entities;
using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    public class ChapterIcd : AuditedEntity<Guid>
    {
        [Description("ID")]
        public string Code { get; set; }

        [Description("Tên Chương")]
        public string Name { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SortOrder { get; set; }

        public bool Inactive { get; set; }
    }
}
