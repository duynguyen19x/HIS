using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Utilities.Enums
{
    public enum ImpMestStatusType
    {
        [Description("Mới tạo")]
        None = 0,

        [Description("Yêu cầu")]
        Request,

        [Description("Đã duyệt")]
        Approved,

        [Description("Đã nhập kho")]
        ReceivedInStock,

        [Description("Đã hủy")]
        Canceled
    }
}
