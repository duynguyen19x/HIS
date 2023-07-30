using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Utilities.Enums
{
    public enum RoomTypes
    {
        [Description("Tiếp đón")]
        Reception = 1,

        [Description("Hành chính")]
        Administration,

        [Description("Khám bệnh")]
        MedicalExamination,

        [Description("Nội trú")]
        InpatientTreatment,

        [Description("Ngoại trú")]
        Outpatient,

        [Description("Xét nghiệm")]
        LaboratoryTesting,

        [Description("Chẩn đoán hình ảnh")]
        DiagnosticImaging,

        [Description("Kho tổng")]
        CentralWarehouse,

        [Description("Kho thuốc ngoại trú")]
        OutpatientPharmacy,

        [Description("Kho thuốc nội trú")]
        InpatientPharmacy,

        [Description("Tủ trực thuốc")]
        EmergencyCabinet,

        [Description("Kho VTYT")]
        OutpatientInventory,

        [Description("Kho máu")]
        BloodBack,

        [Description("Tủ trực VTYT")]
        InventoryCabinet,

        [Description("Quản lý thuốc")]
        MedicineManagement,

        [Description("Quản lý vật tư")]
        MaterialManagement,
    }
}
