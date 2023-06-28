using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Utilities.Enums
{
    public enum ServiceGroupTypes
    {
        [Description("Xét nghiệm huyết học")]
        BloodTest = 1,
        [Description("Xét nghiệm sinh hóa")]
        BiochemicalTest,
        [Description("Xét nghiệm vi sinh")]
        MicrobiologicalTest,
        [Description("Xét nghiệm nước tiểu")]
        UrineTest,
        [Description("Dịch chọc dò")]
        DiagnosticPuncture,
        [Description("Giải phẫu bệnh lý")]
        PathologicalAnatomy,
        [Description("Phẫu thuật")]
        Surgery,
        [Description("Khám")]
        MedicalExamination,
        //[Description("Điện não đồ")]
        //None = 1,
        //[Description("Điện tâm đồ")]
        //None = 1,
        //[Description("Phục hồi chức năng")]
        //None = 1,
        //[Description("Thủ thuật")]
        //None = 1,
        //[Description("Nội soi")]
        //None = 1,
        //[Description("XQuang thường")]
        //None = 1,
        //[Description("XQuang kỹ thuật số")]
        //None = 1,
        //[Description("Cộng hưởng từ")]
        //None = 1,
        //[Description("Cắt lớp vi tính")]
        //None = 1,
        //[Description("Siêu âm")]
        //None = 1,
        //[Description("Siêu âm màu")]
        //None = 1,
        //[Description("Suất ăn")]
        //None = 1,
        //[Description("Máu")]
        //None = 1,
        //[Description("Chế phẩm máu")]
        //None = 1,
        //[Description("Vật tư")]
        //None = 1,
        //[Description("Giường")]
        //None = 1,
        //[Description("Vận chuyển")]
        //None = 1,
        //[Description("Khác")]
        //None = 1
    }
}
