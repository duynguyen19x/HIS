using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Authorization
{
    public interface IPermissionChecker
    {
        /// <summary>
        /// Kiểm tra xem người dùng có được cấp quyền hay không.
        /// </summary>
        /// <param name="userId">Người dùng</param>
        /// <param name="requireAll">Yêu cầu phải có tất cả các quyền</param>
        /// <param name="permissionNames">Danh sách quyền</param>
        /// <returns></returns>
        Task<bool> IsGrantedAsync(IUserIdentifier userIdentifier, bool requireAll, string[] permissionNames);

        /// <summary>
        /// Kiểm tra xem người dùng có được cấp quyền hay không.
        /// </summary>
        /// <param name="userId">Người dùng</param>
        /// <param name="requireAll">Yêu cầu phải có tất cả các quyền</param>
        /// <param name="permissionNames">Danh sách quyền</param>
        /// <returns></returns>
        bool IsGranted(IUserIdentifier userIdentifier, bool requireAll, string[] permissionNames);
    }
}
