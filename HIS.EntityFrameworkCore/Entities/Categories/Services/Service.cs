using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class Service : FullAuditedEntity<Guid>
    {
        [Description("Mã dịch vụ")]
        public string Code { get; set; }

        [Description("Mã BHYT")]
        public string HeInCode { get; set; }

        [Description("Tên dịch vụ")]
        public string Name { get; set; }

        [Description("Tên BHYT")]
        public string HeInName { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SortOrder { get; set; }

        [Description("Đang sử dụng")]
        public bool Inactive { get; set; }

        public Guid? UnitId { get; set; }
        public Guid? ServiceGroupId { get; set; }
        public Guid? ServiceGroupHeInId { get; set; }
        public int? SurgicalProcedureTypeId { get; set; }

        public Unit Unit { get; set; }
        public ServiceGroup ServiceGroup { get; set; }
        public ServiceGroupHeIn ServiceGroupHeIn { get; set; }
        public SurgicalProcedureType SurgicalProcedureType { get; set; }
    }
}
