using HIS.Core.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Authorization
{
    public class PermissionChecker : IPermissionChecker
    {
        public Task<bool> IsGrantedAsync(IUserIdentifier userIdentifier, bool requireAll, string[] permissionNames)
        {
            return Task.FromResult(true);
        }

        public bool IsGranted(IUserIdentifier userIdentifier, bool requireAll, string[] permissionNames)
        {
            return true;
        }
    }
}
