using HIS.EntityFrameworkCore.BaseEntitys;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class SService : FullAuditingEntity<Guid>
    {
        public string? ServiceCode { get; set; }
        public string? ServiceName { get; set; }
        public int? SoftOrder { get; set; }
        public bool? IsActive { get; set; }

        public Guid? ServiceTypeId { get; set; }
        public Guid ServiceUnitId { get; set; }

        public SServiceUnit? SServiceUnit { get; set; }
        public SServiceType? SServiceType { get; set; }
    }
}
