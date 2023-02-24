using HIS.EntityFrameworkCore.BaseEntitys;
using HIS.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class SGender : Entity<Guid>
    {
        public GenderTypes Code { get; set; }
        public string? Name { get; set; }

        public IList<SUser>? Users { get; set; }
    }
}
