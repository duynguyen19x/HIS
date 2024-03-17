using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Runtime.Session
{
    public interface IAppSession
    {
        /// <summary>
        /// Người dùng.
        /// </summary>
        Guid? UserId { get; }

        /// <summary>
        /// Chi nhánh làm việc.
        /// </summary>
        Guid? BranchId { get; }

    }
}
