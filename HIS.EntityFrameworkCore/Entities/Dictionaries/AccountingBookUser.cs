using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities;
using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    public class AccountingBookUser : Entity<Guid>
    {
        public virtual Guid UserId { get; set; }
        public virtual Guid AccountingBookId { get; set; }

        [Ignore]
        public virtual User User { get; set; }

        [Ignore]
        public virtual AccountingBook AccountingBook { get; set; }
    }
}
