using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Utilities.Enums
{
    public enum InOutStatusType
    {
        [Description("Đã hủy")]
        Canceled = -1,

        [Description("Mới tạo")]
        New,

        [Description("Yêu cầu")]
        Request,

        [Description("Đã duyệt")]
        Approved,

        [Description("Đã xuất kho")]
        ReceivedOutStock,

        [Description("Đã nhập kho")]
        ReceivedInStock,
    }
}
