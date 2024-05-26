using HIS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    [Table("SInvoiceGroupBelongToUser")]
    public class InvoiceGroupBelongToUser : Entity<Guid>
    {
        public virtual Guid InvoiceGroupId { get; set; }

        public virtual Guid UserId { get; set; }
    }
}
