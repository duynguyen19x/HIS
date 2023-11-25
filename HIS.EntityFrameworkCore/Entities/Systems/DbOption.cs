using HIS.Core.Entities;
using HIS.Core.Entities.Auditing;
using HIS.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    public class DbOption : Entity<Guid>
    {
        public string DbOptionId { get; set; }
        public string DbOptionValue { get; set; }
        public int DbOptionType { get; set; }
        public string Description { get; set; }
        public Guid? ParentId { get; set; }
        public bool IsParent { get; set; }

    }
}
