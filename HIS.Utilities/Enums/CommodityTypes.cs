using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Utilities.Enums
{
    /// <summary>
    /// Loại hàng hóa
    /// </summary>
    public enum CommodityTypes
    {
        [Description("Thuốc")]
        Item,
        [Description("Vật tư")]
        Material,
        [Description("Máu")]
        Blood,
    }
}
