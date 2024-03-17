using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Authorization
{
    public interface IUserIdentifier
    {
        Guid? BranchId { get; }

        Guid UserId { get; }
    }
}
