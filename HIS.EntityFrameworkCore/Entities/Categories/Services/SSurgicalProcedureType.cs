using HIS.EntityFrameworkCore.BaseEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories.Services
{
    /// <summary>
    /// Loại phẫu thuật thủ thuật
    /// </summary>
    public class SSurgicalProcedureType : FullAuditingEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int? SortOrder { get; set; }

        public IList<SService> SServices { get; set; }
    }
}
