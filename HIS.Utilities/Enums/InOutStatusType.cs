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
        New = 0,

        [Description("Yêu cầu")]
        Request = 1,

        [Description("Đã duyệt")]
        Approved = 2,

        [Description("Đã xuất kho")]
        ReceivedOutStock = 3,

        [Description("Đã nhập kho")]
        ReceivedInStock = 4,
    }
}
