using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Constants
{
    public static class PermissionConst
    {
        #region - Hệ thống

        public const string HIS_SYSTEM = "HIS_SYSTEM_USER";

        public const string HIS_SYSTEM__USER = "HIS_SYSTEM_USER";
        public const string HIS_SYSTEM__USER__CREATE = "HIS_SYSTEM_USER__CREATE";
        public const string HIS_SYSTEM__USER__EDIT = "HIS_SYSTEM_USER__EDIT";
        public const string HIS_SYSTEM__USER__DELETE = "HIS_SYSTEM_USER__DELETE";

        public const string HIS_SYSTEM__ROLE = "HIS_SYSTEM_ROLE";
        public const string HIS_SYSTEM__ROLE__CREATE = "HIS_SYSTEM_ROLE__CREATE";
        public const string HIS_SYSTEM__ROLE__EDIT = "HIS_SYSTEM_ROLE__EDIT";
        public const string HIS_SYSTEM__ROLE__DELETE = "HIS_SYSTEM_ROLE__DELETE";

        public const string HIS_SYSTEM__OPTION = "HIS_SYSTEM_OPTION";
                                        
        public const string HIS_SYSTEM__ACCESS_LOG = "HIS_SYSTEM_ACCESS_LOG";
        public const string HIS_SYSTEM__ACCESS_LOG__CREATE = "HIS_SYSTEM_ACCESS_LOG__CREATE";
        public const string HIS_SYSTEM__ACCESS_LOG__EDIT = "HIS_SYSTEM_ACCESS_LOG__EDIT";
        public const string HIS_SYSTEM__ACCESS_LOG__DELETE = "HIS_SYSTEM_ACCESS_LOG__DELETE";
                                        
        public const string HIS_SYSTEM__LAYOUT_TEMPLATE = "HIS_SYSTEM_LAYOUT_TEMPLATE";
        public const string HIS_SYSTEM__LAYOUT_TEMPLATE__CREATE = "HIS_SYSTEM_LAYOUT_TEMPLATE__CREATE";
        public const string HIS_SYSTEM__LAYOUT_TEMPLATE__EDIT = "HIS_SYSTEM_LAYOUT_TEMPLATE__EDIT";
        public const string HIS_SYSTEM__LAYOUT_TEMPLATE__DELETE = "HIS_SYSTEM_LAYOUT_TEMPLATE__DELETE";

        #endregion

        #region - Danh mục

        public const string HIS_DICTIONARY__BRANCH = "HIS_DICTIONARY__BRANCH";
        public const string HIS_DICTIONARY__BRANCH__CREATE = "HIS_DICTIONARY__BRANCH__CREATE";
        public const string HIS_DICTIONARY__BRANCH__EDIT = "HIS_DICTIONARY__BRANCH__EDIT";
        public const string HIS_DICTIONARY__BRANCH__DELETE = "HIS_DICTIONARY__BRANCH__DELETE";

        public const string HIS_DICTIONARY__DEPARTMENT = "HIS_DICTIONARY__DEPARTMENT";
        public const string HIS_DICTIONARY__DEPARTMENT__CREATE = "HIS_DICTIONARY__DEPARTMENT__CREATE";
        public const string HIS_DICTIONARY__DEPARTMENT__EDIT = "HIS_DICTIONARY__DEPARTMENT__EDIT";
        public const string HIS_DICTIONARY__DEPARTMENT__DELETE = "HIS_DICTIONARY__DEPARTMENT__DELETE";

        #endregion

        #region - Nghiệp vụ

        #endregion

        #region - Báo cáo

        #endregion

        #region - Khác

        #endregion
    }
}
