using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Utilities.Helpers
{
    public class BoolHelper
    {
        public static bool IsNullOrFalse(bool? value)
        {
            return value == null || (value != null && value == false);
        }
    }
}
