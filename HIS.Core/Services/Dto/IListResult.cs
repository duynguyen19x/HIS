using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Services.Dto
{
    public interface IListResult<T>
    {
        IList<T> Result { get; set; }
    }
}
