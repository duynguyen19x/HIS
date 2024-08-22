using System.ComponentModel;

namespace HIS.Utilities.Enums
{
    public enum ServiceResultDataType
    {
        [Description("Bình thường")]
        None = 0,

        [Description("Cao")]
        High,

        [Description("Thấp")]
        Low,
    }
}
