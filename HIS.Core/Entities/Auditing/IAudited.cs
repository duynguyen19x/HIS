using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Entities.Auditing
{
    public interface IAudited : ICreationAudited
    {
        DateTime? ModifiedDate { get; set; }
        Guid? ModifiedBy { get; set; }
    }
}
