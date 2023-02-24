using HIS.EntityFrameworkCore.BaseEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories.Services
{
    public class SServiceUnit : Entity<Guid>
    {
        public bool IsActive { get; set; }
        public string? ServiceUnitCode { get; set; }
        public string? ServiceUnitName { get; set; }
        public int? SortOrder { get; set; }

        public IList<SServiceType>? SServiceTypes { get; set; }
        public IList<SService>? SServices { get; set; }
    }
}
