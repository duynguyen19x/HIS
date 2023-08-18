using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Utilities.Enums
{
    public enum EmpMestStatusType
    {
        [Description("Mới tạo")]
        None = 0,

        [Description("Yêu cầu")]
        Request,

        [Description("Đã duyệt")]
        Approved,

        [Description("Đã xuất kho")]
        ReceivedOutStock,

        [Description("Đã hủy")]
        Canceled
    }
}
