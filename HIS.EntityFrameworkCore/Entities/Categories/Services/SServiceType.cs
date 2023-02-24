using HIS.EntityFrameworkCore.BaseEntitys;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class SServiceType : FullAuditingEntity<Guid>
    {
        public string? ServiceTypeCode { get; set; }
        public string? ServiceTypeName { get; set; }
        public int? SoftOrder { get; set; }
        public bool? IsActive { get; set; }

        public Guid? ServiceUnitId { get; set; }

        public SServiceUnit? SServiceUnit { get; set; }
        public IList<SService>? SServices { get; set; }
    }
}
