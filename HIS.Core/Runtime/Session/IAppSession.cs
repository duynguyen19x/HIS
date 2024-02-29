using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Runtime.Session
{
    public interface IAppSession
    {
        Guid? UserID { get; }
    }
}
