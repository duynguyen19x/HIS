using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Extensions
{
    public static class Check
    {
        public static bool IsNullOrDefault(int? value)
        {
            return value == null || value == default(int);
        }

        public static bool IsNullOrDefault(Guid? value)
        {
            return value == null || value == default(Guid);
        }
    }
}
