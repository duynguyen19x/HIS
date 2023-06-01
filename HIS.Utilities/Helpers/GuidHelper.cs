using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Utilities.Helpers
{
    public class GuidHelper
    {
        public static bool IsNullOrEmpty(Guid? guid)
        {
            return guid == null || (guid != null && guid == Guid.Empty);
        }
    }
}
