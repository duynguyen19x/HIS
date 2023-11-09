using HIS.Core.Entities;
using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    public class RelativeType : AuditedEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public RelativeType() { }
        public RelativeType(Guid id, string code, string name, int sortOrder)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
            this.SortOrder = sortOrder;
        }
    }
}
