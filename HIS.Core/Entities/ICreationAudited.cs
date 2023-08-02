using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Entities
{
    public interface ICreationAudited
    {
        DateTime CreatedDate { get; set; }
        Guid? CreatedBy { get; set; }
    }
}
