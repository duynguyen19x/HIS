using HIS.EntityFrameworkCore.BaseEntitys;
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
    public class SService : FullAuditingEntity<Guid>
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

        public Guid? ServiceTypeId { get; set; }
        public Guid? ServiceUnitId { get; set; }
        public Guid? ServiceGroupId { get; set; }
        public Guid? ServiceGroupHeInId { get; set; }
        public Guid? SurgicalProcedureTypeId { get; set; }

        public SServiceUnit SServiceUnit { get; set; }
        public SServiceType SServiceType { get; set; }
        public SServiceGroup SServiceGroup { get; set; }
        public SServiceGroupHeIn SServiceGroupHeIn { get; set; }
        public SSurgicalProcedureType SSurgicalProcedureType { get; set; }

        public IList<SMedicineType> SMedicineTypes { get; set; }
        public IList<SMedicine> SMedicines { get; set; }

        public IList<SMaterial> SMaterials { get; set; }
        public IList<SMaterialType> SMaterialTypes { get; set; }

        public IList<SServicePricePolicy> SServicePricePolicies { get; set; }

        public IList<SExecutionRoom> ExecutionRooms { get; set; }
    }
}
