using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Utilities.Enums
{
    public enum ImMestStatusType
    {
        [Description("Mới tạo")]
        None = 0,

        [Description("Đã nhập kho")]
        ReceivedInStock,

        [Description("Đã hủy")]
        Canceled
    }
}
