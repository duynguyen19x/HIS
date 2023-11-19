﻿using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    public class TreatmentType : AuditedEntity<int>
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int SortOrder { get; set; }
        public virtual bool Inactive { get; set; }

        public TreatmentType() { }
        public TreatmentType(int id, string name, int sortOrder)
        {
            this.Id = id;
            this.Code = id.ToString();
            this.Name = name;
            this.SortOrder = sortOrder;
            this.Inactive = false;
        }
    }
}
