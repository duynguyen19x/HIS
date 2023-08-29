using System.ComponentModel;

namespace HIS.Utilities.Enums
{
    public enum ExpMestStatusType
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
