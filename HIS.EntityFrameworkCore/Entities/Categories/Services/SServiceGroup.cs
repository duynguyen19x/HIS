using HIS.EntityFrameworkCore.BaseEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class SServiceGroup : Entity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public List<SService> SServices { get; set; }
    }
}
