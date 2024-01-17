using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Services.Dto
{
    public interface IHasTotalCount
    {
        int TotalCount { get; set; }
    }
}
