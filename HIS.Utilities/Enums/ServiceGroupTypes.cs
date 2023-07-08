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

        [Description("Xét nghiệm khác")]
        TestOther,

        [Description("Phẫu thuật")]
        Surgery,

        [Description("Khám")]
        MedicalExamination,

        [Description("Điện não đồ")]
        EEG,

        [Description("Điện tâm đồ")]
        ECG,

        [Description("Phục hồi chức năng")]
        FunctionalRecovery,

        [Description("Thủ thuật")]
        SurgicalIntervention,

        [Description("Nội soi")]
        Endoscopy,

        [Description("XQuang thường")]
        Xray,

        [Description("XQuang kỹ thuật số")]
        XrayDigital,

        [Description("Cộng hưởng từ")]
        MRI,

        [Description("Cắt lớp vi tính")]
        CTScan,

        [Description("Siêu âm")]
        Ultrasound,

        [Description("Siêu âm màu")]
        Doppler,

        [Description("Suất ăn")]
        MealPortion,

        [Description("Máu")]
        Blood,

        [Description("Chế phẩm máu")]
        BloodProduct,

        [Description("Vật tư")]
        Material,

        [Description("Thuốc")]
        Medicine,

        [Description("Giường")]
        Bed,

        [Description("Vận chuyển")]
        Transportation,

        [Description("Khác")]
        Other
    }
}
