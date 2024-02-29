using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Runtime.Session
{
    public class NullAppSession : IAppSession
    {
        /// <summary>
        /// Singleton instance.
        /// </summary>
        public static NullAppSession Instance { get; } = new NullAppSession();

        public Guid? UserID => null;

        private NullAppSession()
        {

        }
    }
}
