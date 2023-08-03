using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Entities.Auditing
{
    public interface IFullAudited : IAudited
    {
        DateTime? DeletedDate { get; set; }
        Guid? DeletedBy { get; set; }
        bool IsDeleted { get; set; } 
    }
}
