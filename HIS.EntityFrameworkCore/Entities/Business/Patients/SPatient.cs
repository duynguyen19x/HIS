using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business.Patients
{
    public class SPatient : FullAuditedEntity<Guid>
    {
        public virtual string Code { get; set; } 
        public virtual string Name { get; set; }
        public virtual DateTime? BirthDate { get; set; }
        public virtual int BirthYear { get; set; }
        public virtual string Address { get; set; }

        public virtual Guid GenderId { get; set; }

        public virtual SGender Gender { get; set; }
    }
}
