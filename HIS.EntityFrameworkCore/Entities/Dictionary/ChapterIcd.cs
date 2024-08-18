using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Entities.Auditing;
using System.ComponentModel;

namespace HIS.EntityFrameworkCore.Entities
{
    public class ChapterIcd : AuditedEntity<Guid>
    {
        [Description("Code")]
        public string Code { get; set; }

        [Description("Tên Chương")]
        public string Name { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SortOrder { get; set; }

        public bool Inactive { get; set; }
    }
}
