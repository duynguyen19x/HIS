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
        Administration = 2,

        [Description("Khám bệnh")]
        MedicalExamination = 3,

        [Description("Nội trú")]
        InpatientTreatment = 4,

        [Description("Ngoại trú")]
        Outpatient = 5,

        [Description("Xét nghiệm")]
        LaboratoryTesting = 6,

        [Description("Chẩn đoán hình ảnh")]
        DiagnosticImaging = 7,

        [Description("Kho tổng")]
        CentralWarehouse = 8,

        [Description("Kho thuốc ngoại trú")]
        OutpatientPharmacy = 9,

        [Description("Kho thuốc nội trú")]
        InpatientPharmacy = 10,

        [Description("Tủ trực thuốc")]
        EmergencyCabinet = 11,

        [Description("Kho VTYT")]
        OutpatientInventory = 12,

        [Description("Kho máu")]
        BloodBack = 13,

        [Description("Tủ trực VTYT")]
        InventoryCabinet = 14,

        [Description("Quản lý thuốc")]
        ItemManagement = 15,

        [Description("Quản lý vật tư")]
        MaterialManagement = 16,
    }
}
