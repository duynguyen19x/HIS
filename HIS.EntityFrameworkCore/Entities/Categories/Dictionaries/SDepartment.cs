using HIS.EntityFrameworkCore.BaseEntitys;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories.Dictionaries
{
    public class SDepartment : AuditingEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid BranchId { get; set; }
        public bool Inactive { get; set; }

        public virtual SBranch SBranch { get; set; }
        public IList<SRoom> Rooms { get; set; }
    }
}
