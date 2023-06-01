using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Commons
{
    public class ApiResultList<T>
    {
        public bool IsSuccessed { get; set; } = true;

        public string Message { get; set; }

        public int TotalCount { get; set; }

        public IList<T> Result { get; set; }
    }
}
