using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Utilities.Commons
{
    public class TokenConsts
    {
        public static TimeSpan AcceptTokenExpiration = TimeSpan.FromMinutes(15);
        public static TimeSpan RefreshTokenExpiration = TimeSpan.FromDays(1);
    }
}
