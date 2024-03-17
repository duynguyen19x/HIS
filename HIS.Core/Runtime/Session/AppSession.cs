using HIS.Utilities.Sections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Runtime.Session
{
    public class AppSession : IAppSession
    {
        public Guid? UserId
        {
            get
            {
                return SessionExtensions.Login?.Id;
            }
        }

        public Guid? BranchId
        {
            get
            {
                return null;
            }
        }
    }
}
