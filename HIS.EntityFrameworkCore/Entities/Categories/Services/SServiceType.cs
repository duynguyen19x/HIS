using HIS.EntityFrameworkCore.BaseEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class SServiceType : FullAuditingEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int? SoftOrder { get; set; }
        public bool? IsActive { get; set; }

        public Guid? ServiceUnitId { get; set; }

        public SServiceUnit SServiceUnit { get; set; }
        public IList<SService> SServices { get; set; }
    }
}
