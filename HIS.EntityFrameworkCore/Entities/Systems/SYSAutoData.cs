using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    [Table("SYSAutoData")]
    public class SYSAutoData : AuditedEntity<Guid>
    {

    }
}
